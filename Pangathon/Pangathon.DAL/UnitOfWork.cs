using Pangathon.DAL.Entities;
using Pangathon.DAL.Interfaces;
using System;

namespace Pangathon.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PangathonContext _context;

        public UnitOfWork(PangathonContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        private IGenericRepository<Adresse, Guid> adresseRepository;
        private IGenericRepository<Commentaire, Guid> commentaireRepository;
        private IGenericRepository<Entreprise, Guid> entrepriseRepository;
        private IGenericRepository<Poste, Guid> posteRepository;
        private IGenericRepository<Priorite, Guid> prioriteRepository;
        private IGenericRepository<Role, Guid> roleRepository;
        private IGenericRepository<Statut, Guid> statutRepository;
        private IGenericRepository<Tache, Guid> tacheRepository;
        private IGenericRepository<TypeTache, Guid> typeTacheRepository;
        private IGenericRepository<Utilisateur, Guid> utilisateurRepository;
        private IGenericRepository<Ville, Guid> villeRepository;

        public IGenericRepository<Adresse, Guid> AdresseRepository
        {
            get
            {
                if (adresseRepository == null)
                    adresseRepository = new GenericRepository<Adresse, Guid>(_context);
                return adresseRepository;
            }
        }

        public IGenericRepository<Commentaire, Guid> CommentaireRepository
        {
            get
            {
                if (commentaireRepository == null)
                    commentaireRepository = new GenericRepository<Commentaire, Guid>(_context);
                return commentaireRepository;
            }
        }

        public IGenericRepository<Entreprise, Guid> EntrepriseRepository
        {
            get
            {
                if (entrepriseRepository == null)
                    entrepriseRepository = new GenericRepository<Entreprise, Guid>(_context);
                return entrepriseRepository;
            }
        }

        public IGenericRepository<Poste, Guid> PosteRepository
        {
            get
            {
                if (posteRepository == null)
                    posteRepository = new GenericRepository<Poste, Guid>(_context);
                return posteRepository;
            }
        }

        public IGenericRepository<Priorite, Guid> PrioriteRepository
        {
            get
            {
                if (prioriteRepository == null)
                    prioriteRepository = new GenericRepository<Priorite, Guid>(_context);
                return prioriteRepository;
            }
        }

        public IGenericRepository<Role, Guid> RoleRepository
        {
            get
            {
                if (roleRepository == null)
                    roleRepository = new GenericRepository<Role, Guid>(_context);
                return roleRepository;
            }
        }

        public IGenericRepository<Statut, Guid> StatutRepository
        {
            get
            {
                if (statutRepository == null)
                    statutRepository = new GenericRepository<Statut, Guid>(_context);
                return statutRepository;
            }
        }

        public IGenericRepository<Tache, Guid> TacheRepository
        {
            get
            {
                if (tacheRepository == null)
                    tacheRepository = new GenericRepository<Tache, Guid>(_context);
                return tacheRepository;
            }
        }

        public IGenericRepository<TypeTache, Guid> TypeTacheRepository
        {
            get
            {
                if (typeTacheRepository == null)
                    typeTacheRepository = new GenericRepository<TypeTache, Guid>(_context);
                return typeTacheRepository;
            }
        }

        public IGenericRepository<Utilisateur, Guid> UtilisateurRepository
        {
            get
            {
                if (utilisateurRepository == null)
                    utilisateurRepository = new GenericRepository<Utilisateur, Guid>(_context);
                return utilisateurRepository;
            }
        }

        public IGenericRepository<Ville, Guid> VilleRepository
        {
            get
            {
                if (villeRepository == null)
                    villeRepository = new GenericRepository<Ville, Guid>(_context);
                return villeRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
