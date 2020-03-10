using Pangathon.Api.Tools.Entities;
using Pangathon.DAL.Entities;
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
                Id = System.Guid.NewGuid(),
                Nom = "Pikachu",
                Prenom = "Michael",
                Email = "Mike@charleroi.com",
                Img = "https://www.revivre.org/wp-content/uploads/2016/03/retablissement.png",
                Telephone = "0477 55 55 55 ",
                Entreprise = EntrepriseTools.GenerateEntView(),
                Poste = "Stagiaire"
                
            };
        }

        public static UtilisateurView UtToUtV(Utilisateur u)
        {
            return new UtilisateurView()
            {
                Id = u.Id,
                Nom = u.Nom,
                Prenom = u.Prenom,
                Email = u.Email,
                Img = u.Image,
                Telephone = u.Telephone,
                Entreprise = EntrepriseTools.EnToEnV(u.Entreprise),
                Poste = u.Poste.Nom
            };
        }

        

        public static List<UtilisateurView> listTolistV(List<Utilisateur> lu)
        {
            List<UtilisateurView> luv = new List<UtilisateurView>();
            foreach (Utilisateur u in lu)
            {
                luv.Add(UtToUtV(u));
            }
            return luv;
        }

    }
}
