using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pangathon.Api.Tools;
using Pangathon.Api.Tools.Entities;

namespace Pangathon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {

        public UtilisateurView Get()
        {
            UtilisateurView utilisateur = UtilisateurTools.GenerateUtView();
            return utilisateur;
        }

        [HttpGet("getall")]
        public List<UtilisateurView> GetAll()
        {
            List<UtilisateurView> listeUtilisateur = new List<UtilisateurView>();
            for (int i = 0; i < 4; i++)
            {
                listeUtilisateur.Add(UtilisateurTools.GenerateUtView());
            }
            return listeUtilisateur;
        }

        [HttpGet("nom/{paramsNom}")]
        public List<UtilisateurView> FilterByNom(string paramsNom)
        {
            List<UtilisateurView> listeUtilisateur = new List<UtilisateurView>();
            for (int i = 0; i < 4; i++)
            {
                listeUtilisateur.Add(UtilisateurTools.GenerateUtView());
            }
            List<UtilisateurView> newList = listeUtilisateur.Where(x => x.Nom == paramsNom).ToList();
            return newList;

        }

    }
}