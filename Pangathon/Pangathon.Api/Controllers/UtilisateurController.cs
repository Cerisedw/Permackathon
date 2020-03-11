using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pangathon.Api.Tools;
using Pangathon.Api.Tools.Entities;
using Pangathon.DAL.Interfaces;

namespace Pangathon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly string _includeString = "Entreprise,Entreprise.Adresse,Entreprise.Adresse.Ville,Poste";

        public UtilisateurController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{idUtilisateur}")]
        public UtilisateurView Get(Guid idUtilisateur)
        {
            UtilisateurView utilisateur = UtilisateurTools.UtToUtV(_unitOfWork.UtilisateurRepository.GetById(idUtilisateur, _includeString));
            return utilisateur;
        }

        [HttpGet("getall")]
        public List<UtilisateurView> GetAll()
        {
            List<UtilisateurView> listeUtilisateur = UtilisateurTools.listTolistV(_unitOfWork.UtilisateurRepository.Get(null, null, _includeString).ToList());
            
            return listeUtilisateur;
        }

        [HttpGet("getall/nom/{paramsNom}")]
        public List<UtilisateurView> FilterByNom(string paramsNom)
        {
            List<UtilisateurView> listeUtilisateur = UtilisateurTools.listTolistV(_unitOfWork.UtilisateurRepository.Get().ToList());
            List<UtilisateurView> newList = listeUtilisateur.Where(x => x.Nom == paramsNom).ToList();
            return newList;

        }

    }
}