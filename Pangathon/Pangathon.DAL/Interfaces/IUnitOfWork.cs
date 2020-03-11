using Pangathon.DAL.Entities;
using System;

namespace Pangathon.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Adresse> AdresseRepository { get; }
        IGenericRepository<Commentaire> CommentaireRepository { get; }
        IGenericRepository<Entreprise> EntrepriseRepository { get; }
        IGenericRepository<Poste> PosteRepository { get; }
        IGenericRepository<Priorite> PrioriteRepository { get; }
        IGenericRepository<Role> RoleRepository { get; }
        IGenericRepository<Statut> StatutRepository { get; }
        IGenericRepository<Tache> TacheRepository { get; }
        IGenericRepository<TypeTache> TypeTacheRepository { get; }
        IGenericRepository<Utilisateur> UtilisateurRepository { get; }
        IGenericRepository<Ville> VilleRepository { get; }

        void Save();
    }
}
