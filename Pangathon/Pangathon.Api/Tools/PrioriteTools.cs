using Pangathon.Api.Tools.Entities;
using Pangathon.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pangathon.Api.Tools
{
    public static class PrioriteTools
    {

        public static PrioriteView PrioToPrioV(Priorite p)
        {
            return new PrioriteView()
            {
                Nom = p.Nom,
                Niveau = p.Niveau
            };
        }

    }
}
