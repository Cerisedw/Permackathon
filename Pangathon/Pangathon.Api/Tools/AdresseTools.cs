using Pangathon.Api.Tools.Entities;
using Pangathon.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pangathon.Api.Tools
{
    public static class AdresseTools
    {

        public static AdresseView AdrToAdrV(Adresse a)
        {
            return new AdresseView()
            {
                Rue = a.Rue,
                Numero = a.Numero,
                Boite = a.Boite,
                CodePostal = a.CodePostal,
                Ville = a.Ville.Nom
            };
        }

    }
}
