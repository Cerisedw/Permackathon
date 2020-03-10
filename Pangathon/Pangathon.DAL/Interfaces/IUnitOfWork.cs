using Pangathon.DAL.Entities;
using System;

namespace Pangathon.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Adresse, Guid> AdresseRepository { get; }
        IGenericRepository<Commentaire, Guid> CommentaireRepository { get; }
        IGenericRepository<Entreprise, Guid> EntrepriseRepository { get; }
        IGenericRepository<Poste, Guid> PosteRepository { get; }
        IGenericRepository<Priorite, Guid> PrioriteRepository { get; }
        IGenericRepository<Role, Guid> RoleRepository { get; }
        IGenericRepository<Statut, Guid> StatutRepository { get; }
        IGenericRepository<Tache, Guid> TacheRepository { get; }
        IGenericRepository<TypeTache, Guid> TypeTacheRepository { get; }
        IGenericRepository<Utilisateur, Guid> UtilisateurRepository { get; }
        IGenericRepository<Ville, Guid> VilleRepository { get; }

        void Save();
    }
}
