using Pangathon.Api.Tools.Entities;
using Pangathon.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pangathon.Api.Tools
{
    public static class EntrepriseTools
    {

        public static EntrepriseView GenerateEntView()
        {
            return new EntrepriseView() 
            {
                Nom = "PermaFungi",
                Telephone = "02 555 55 55",
                Description = "Permafungi est une coopérative à finalité sociale basée à Bruxelles qui recycle un déchet urbain - le marc de café !"
            };
        }

        public static EntrepriseView EnToEnV(Entreprise e)
        {
            return new EntrepriseView()
            {
                Nom = e.Nom,
                Telephone = e.Telephone,
                Description = e.Description,
                Adresse = AdresseTools.AdrToAdrV(e.Adresse)
            };
        }


        public static List<EntrepriseView> listToListV(List<Entreprise> le)
        {
            List<EntrepriseView> lev = new List<EntrepriseView>();
            foreach(Entreprise e in le)
            {
                lev.Add(EnToEnV(e));
            }
            return lev;
        }

    }
}
