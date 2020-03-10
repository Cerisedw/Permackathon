using Pangathon.Api.Tools.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pangathon.Api.Tools
{
    public static class TacheTools
    {

        public static TacheView GenerateTacheView()
        {
            return new TacheView()
            {
                Id = System.Guid.NewGuid(),
                Nom = "Réparation frigo",
                Description = "Une réparation du frigo qui fuit dans le sous-sol.",
                DateCreation = DateTime.Now,
                DateDeadLine = null,
                Createur = UtilisateurTools.GenerateUtView(),
                Priorite = new PrioriteView() { Nom = "Haute", Niveau = 3 },
                Statut = "En attente",
                Entreprise = EntrepriseTools.GenerateEntView(),
                Type = new TypeView() { Nom = "R&H", Parent = new TypeView() { Nom = "Production" } },
                Participants = new List<UtilisateurView>() { UtilisateurTools.GenerateUtView(), UtilisateurTools.GenerateUtView() }
            };
        }

    }
}
