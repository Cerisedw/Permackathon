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

        public TacheController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{idTache}")]
        // parametre, Guid idTache
        public TacheView Get(Guid idTache)
        {
            TacheView tacheTest  = TacheTools.TacheToTacheV(_unitOfWork.TacheRepository.GetById(idTache));
            return tacheTest;
        }

        [HttpGet("getall")]
        public List<TacheView> GetAll()
        {
            List<TacheView> listeTaches = TacheTools.listTolistView(_unitOfWork.TacheRepository.Get().ToList());
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
            Utilisateur u = _unitOfWork.UtilisateurRepository.GetById(Guid.Parse(""));
            Tache t = TacheTools.TacheAjoutToTache(tacheajout);
            t.Createur = u;
            List<Priorite> lp = _unitOfWork.PrioriteRepository.Get(x => x.Nom == tacheajout.Priorite, null, null).ToList();
            foreach (Priorite p in lp)
            {
                t.Priorite = p;
            }
            List<Entreprise> le = _unitOfWork.EntrepriseRepository.Get(x => x.Nom == tacheajout.Entreprise, null, null).ToList();
            foreach(Entreprise e in le)
            {
                t.Entreprise = e;
            }
            List<TypeTache> lt = _unitOfWork.TypeTacheRepository.Get(x => x.Nom == tacheajout.Type, null, null).ToList();
            foreach(TypeTache tt in lt)
            {
                t.TypeTache = tt;
            }
            Tache tache = _unitOfWork.TacheRepository.Insert(t);
        }

    }
}