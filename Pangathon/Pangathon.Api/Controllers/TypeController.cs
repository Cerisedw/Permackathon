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
    public class TypeController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly string _includeString = "Parent";

        public TypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet("getall")]
        public List<TypeView> GetAll()
        {
            List<TypeView> listeTypes = TypeTools.listToListV(_unitOfWork.TypeTacheRepository.Get(null, null, _includeString));
            return listeTypes;
        }

    }
}