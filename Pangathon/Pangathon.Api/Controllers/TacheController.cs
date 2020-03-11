using Microsoft.AspNetCore.Mvc;
using Pangathon.Api.Tools;
using Pangathon.Api.Tools.Entities;
using Pangathon.DAL.Entities;
using Pangathon.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pangathon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacheController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly string _includeTache = "Createur,Createur.Poste,Createur.Entreprise,Priorite,Statut,Entreprise,Entreprise.Adresse,Entreprise.Adresse.Ville,TypeTache,TypeTache.Parent,Participants,Commentaires";
        private readonly string _includeUtilisateur = "Entreprise,Entreprise.Adresse,Entreprise.Adresse.Ville,Poste,Participations";
        private readonly string _includeEntreprise = "Adresse,Adresse.Ville";
        private readonly string _includeTypeTache = "Parent";

        public TacheController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{idTache}")]
        // parametre, Guid idTache
        public TacheView Get(Guid idTache)
        {
            TacheView tacheTest = TacheTools.TacheToTacheV(_unitOfWork.TacheRepository.GetById(idTache, _includeTache));
            return tacheTest;
        }

        [HttpGet("getall")]
        public List<TacheView> GetAll()
        {
            List<TacheView> listeTaches = TacheTools.listTolistView(_unitOfWork.TacheRepository.Get(null, null, _includeTache).ToList());
            return listeTaches;
        }


        [HttpGet("order/priorite")]
        public List<TacheView> OrderByPriorite()
        {
            List<TacheView> listeTaches = TacheTools.listTolistView(_unitOfWork.TacheRepository.Get(null, null, _includeTache).ToList());
            return listeTaches.OrderByDescending(x => x.Priorite.Niveau).ToList();
        }


        [HttpPost()]
        public string Ajout(TacheAjout tacheajout)
        {
            try
            {
                Utilisateur u = _unitOfWork.UtilisateurRepository.GetById(Guid.Parse("ad70b45f-09a8-4a5a-8e6f-c46a4530befb"), _includeUtilisateur); // Utilisateur : Michael
                Tache t = TacheTools.TacheAjoutToTache(tacheajout);
                t.Createur = u;
                t.Priorite = _unitOfWork.PrioriteRepository.Get(x => x.Nom == tacheajout.Priorite, null, "").FirstOrDefault();
                t.Entreprise = _unitOfWork.EntrepriseRepository.Get(x => x.Nom == tacheajout.Entreprise, null, _includeEntreprise).FirstOrDefault();
                t.TypeTache = _unitOfWork.TypeTacheRepository.Get(x => x.Nom == tacheajout.Type, null, _includeTypeTache).FirstOrDefault();
                t.Statut = _unitOfWork.StatutRepository.GetById(Guid.Parse("a3419a76-b03b-4402-9756-5b4207ef7819")); // Statut 'En attente'
                t.Id = Guid.NewGuid();
                Tache tache = _unitOfWork.TacheRepository.Insert(t);
                _unitOfWork.Save();
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        [HttpPost("participant")]
        public void AjoutParticipant(TacheParticipant tacheParticipant)
        {
            Utilisateur utilisateur = _unitOfWork.UtilisateurRepository.GetById(tacheParticipant.UtilisateurId, _includeUtilisateur);
            Tache tache = _unitOfWork.TacheRepository.GetById(tacheParticipant.TacheId, _includeTache);
            Participant participant = new Participant { Tache = tache, TacheId = tache.Id, Utilisateur = utilisateur, UtilisateurId = utilisateur.Id };
            tache.Participants.Add(participant);
            utilisateur.Participations.Add(participant);
            _unitOfWork.Save();
        }

    }
}