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
    public class EntrepriseController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly string _includeString = "Adresse,Adresse.Ville";

        public EntrepriseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{idEntreprise}")]
        public EntrepriseView Get(Guid idEntreprise)
        {
            EntrepriseView entreprise = EntrepriseTools.EnToEnV(_unitOfWork.EntrepriseRepository.GetById(idEntreprise, _includeString));
            return entreprise;
        }

        [HttpGet("getall")]
        public List<EntrepriseView> GetAll()
        {
            List<EntrepriseView> listeEntreprise = EntrepriseTools.listToListV(_unitOfWork.EntrepriseRepository.Get(null, null, _includeString).ToList());
            return listeEntreprise;
        }


    }
}