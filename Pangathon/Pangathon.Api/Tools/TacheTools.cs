using Pangathon.Api.Tools.Entities;
using Pangathon.DAL.Entities;
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


        public static TacheView TacheToTacheV(Tache t)
        {
            List<Utilisateur> lu = new List<Utilisateur>();
            foreach (Participant p in t.Participants)
            {
                lu.Add(p.Utilisateur);
            }
            return new TacheView()
            {
                Id = t.Id,
                Nom = t.Nom,
                Description = t.Description,
                DateCreation = t.DateCreation,
                DateDeadLine = t.DateDeadline,
                Createur = UtilisateurTools.UtToUtV(t.Createur),
                Priorite = PrioriteTools.PrioToPrioV(t.Priorite),
                Statut = t.Statut.Nom,
                Entreprise = EntrepriseTools.EnToEnV(t.Entreprise),
                Type = TypeTools.tToTV(t.TypeTache),
                Participants = UtilisateurTools.listTolistV(lu),
            };
        }


        public static List<TacheView> listTolistView(List<Tache> lt)
        {
            List<TacheView> ltv = new List<TacheView>();
            foreach(Tache t in lt)
            {
                ltv.Add(TacheToTacheV(t));
            }
            return ltv;
        }

    }
}
