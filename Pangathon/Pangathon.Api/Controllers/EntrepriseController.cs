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

        public EntrepriseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{idEntreprise}")]
        public EntrepriseView Get(Guid idEntreprise)
        {
            EntrepriseView entreprise = EntrepriseTools.EnToEnV(_unitOfWork.EntrepriseRepository.GetById(idEntreprise));
            return entreprise;
        }

        [HttpGet("getall")]
        public List<EntrepriseView> GetAll()
        {
            List<EntrepriseView> listeEntreprise = EntrepriseTools.listToListV(_unitOfWork.EntrepriseRepository.Get().ToList());
            return listeEntreprise;
        }


    }
}