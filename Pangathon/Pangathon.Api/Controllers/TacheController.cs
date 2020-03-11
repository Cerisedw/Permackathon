using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pangathon.Api.Tools;
using Pangathon.Api.Tools.Entities;
using Pangathon.DAL.Entities;
using Pangathon.DAL.Interfaces;

namespace Pangathon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacheController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly string _includeString = "Createur,Createur.Poste,Createur.Entreprise,Priorite,Statut,Entreprise,Entreprise.Adresse,Entreprise.Adresse.Ville,TypeTache,TypeTache.Parent,Participants,Commentaires";

        public TacheController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{idTache}")]
        // parametre, Guid idTache
        public TacheView Get(Guid idTache)
        {
            TacheView tacheTest  = TacheTools.TacheToTacheV(_unitOfWork.TacheRepository.GetById(idTache, _includeString));
            return tacheTest;
        }

        [HttpGet("getall")]
        public List<TacheView> GetAll()
        {
            List<TacheView> listeTaches = TacheTools.listTolistView(_unitOfWork.TacheRepository.Get(null, null, _includeString).ToList());
            return listeTaches;
        }


        [HttpGet("order/priorite")]
        public List<TacheView> OrderByPriorite ()
        {
            List<TacheView> listeTaches = TacheTools.listTolistView(_unitOfWork.TacheRepository.Get().ToList());
            return listeTaches.OrderByDescending(x => x.Priorite.Niveau ).ToList();
        }


        [HttpPost()]
        public void Ajout(TacheAjout tacheajout)
        {
            Utilisateur u = _unitOfWork.UtilisateurRepository.GetById(Guid.Parse(""), "Entreprise,Entreprise.Adresse,Entreprise.Adresse.Ville,Poste");
            Tache t = TacheTools.TacheAjoutToTache(tacheajout);
            t.Createur = u;
            t.Priorite = _unitOfWork.PrioriteRepository.Get(x => x.Nom == tacheajout.Priorite, null, null).FirstOrDefault();
            t.Entreprise = _unitOfWork.EntrepriseRepository.Get(x => x.Nom == tacheajout.Entreprise, null, "Adresse,Adresse.Ville").FirstOrDefault();
            t.TypeTache = _unitOfWork.TypeTacheRepository.Get(x => x.Nom == tacheajout.Type, null, "Parent").FirstOrDefault();
            t.Statut = _unitOfWork.StatutRepository.GetById(Guid.Parse(""));
            Tache tache = _unitOfWork.TacheRepository.Insert(t);
        }

    }
}