using Pangathon.Api.Tools.Entities;
using Pangathon.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pangathon.Api.Tools
{
    public static class TypeTools
    {

        public static TypeView tToTV(TypeTache t)
        {
            return new TypeView()
            {
                Nom = t.Nom,
                Parent = tToTV(t.Parent)
            };
        }

    }
}
