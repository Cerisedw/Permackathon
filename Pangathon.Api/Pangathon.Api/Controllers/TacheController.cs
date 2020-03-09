using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pangathon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacheController : ControllerBase
    {

        public List<TacheView> Get()
        {

            List<ITache> listTache = repository.GetAll();
            List<TacheView> listTacheView  = TacheTools.listItacheTotacheView(listTache);

            // va retourner du Json si il est demandé.
            return listTacheView;
        }

        

        // on prend le nomUser qu'on recoit en parametre depuis le front end. 
        [HttpGet("{nomUser}")]
        public List<TacheView> Get(string nomUser)
        {
            //List<ITache> listTache = repository.GetAll();
            //List<tacheView> listTacheView = tacheTools.listItacheTotacheView(listTache);

            //return listTacheView;
        }



    }
}