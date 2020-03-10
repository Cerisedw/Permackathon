﻿using System;
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


    }
}