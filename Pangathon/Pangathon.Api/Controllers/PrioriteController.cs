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
    public class PrioriteController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public PrioriteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet("getall")]
        public List<PrioriteView> GetAll()
        {
            List<PrioriteView> listePrio = PrioriteTools.listToListV(_unitOfWork.PrioriteRepository.Get());
            return listePrio;
        }

    }
}