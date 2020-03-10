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

        public static List<PrioriteView> listToListV(IEnumerable<Priorite> lp)
        {
            List<PrioriteView> lpv = new List<PrioriteView>();
            foreach(Priorite p in lp)
            {
                lpv.Add(PrioToPrioV(p));
            }
            return lpv;
        }

    }
}
