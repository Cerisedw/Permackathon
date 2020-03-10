using Pangathon.Api.Tools.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pangathon.Api.Tools
{
    public static class UtilisateurTools
    {

        public static UtilisateurView GenerateUtView()
        {
            return new UtilisateurView()
            {
                Nom = "Pikachu",
                Prenom = "Michael",
                Email = "Mike@charleroi.com",
                Img = "https://www.revivre.org/wp-content/uploads/2016/03/retablissement.png",
                Telephone = "0477 55 55 55 ",
                Entreprise = EntrepriseTools.GenerateEntView(),
                Poste = "Stagiaire"
                
            };
        }

    }
}
