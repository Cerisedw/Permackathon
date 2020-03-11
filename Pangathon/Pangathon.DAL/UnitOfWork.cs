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

        private IGenericRepository<Adresse> adresseRepository;
        private IGenericRepository<Commentaire> commentaireRepository;
        private IGenericRepository<Entreprise> entrepriseRepository;
        private IGenericRepository<Poste> posteRepository;
        private IGenericRepository<Priorite> prioriteRepository;
        private IGenericRepository<Role> roleRepository;
        private IGenericRepository<Statut> statutRepository;
        private IGenericRepository<Tache> tacheRepository;
        private IGenericRepository<TypeTache> typeTacheRepository;
        private IGenericRepository<Utilisateur> utilisateurRepository;
        private IGenericRepository<Ville> villeRepository;

        public IGenericRepository<Adresse> AdresseRepository
        {
            get
            {
                if (adresseRepository == null)
                    adresseRepository = new GenericRepository<Adresse>(_context);
                return adresseRepository;
            }
        }

        public IGenericRepository<Commentaire> CommentaireRepository
        {
            get
            {
                if (commentaireRepository == null)
                    commentaireRepository = new GenericRepository<Commentaire>(_context);
                return commentaireRepository;
            }
        }

        public IGenericRepository<Entreprise> EntrepriseRepository
        {
            get
            {
                if (entrepriseRepository == null)
                    entrepriseRepository = new GenericRepository<Entreprise>(_context);
                return entrepriseRepository;
            }
        }

        public IGenericRepository<Poste> PosteRepository
        {
            get
            {
                if (posteRepository == null)
                    posteRepository = new GenericRepository<Poste>(_context);
                return posteRepository;
            }
        }

        public IGenericRepository<Priorite> PrioriteRepository
        {
            get
            {
                if (prioriteRepository == null)
                    prioriteRepository = new GenericRepository<Priorite>(_context);
                return prioriteRepository;
            }
        }

        public IGenericRepository<Role> RoleRepository
        {
            get
            {
                if (roleRepository == null)
                    roleRepository = new GenericRepository<Role>(_context);
                return roleRepository;
            }
        }

        public IGenericRepository<Statut> StatutRepository
        {
            get
            {
                if (statutRepository == null)
                    statutRepository = new GenericRepository<Statut>(_context);
                return statutRepository;
            }
        }

        public IGenericRepository<Tache> TacheRepository
        {
            get
            {
                if (tacheRepository == null)
                    tacheRepository = new GenericRepository<Tache>(_context);
                return tacheRepository;
            }
        }

        public IGenericRepository<TypeTache> TypeTacheRepository
        {
            get
            {
                if (typeTacheRepository == null)
                    typeTacheRepository = new GenericRepository<TypeTache>(_context);
                return typeTacheRepository;
            }
        }

        public IGenericRepository<Utilisateur> UtilisateurRepository
        {
            get
            {
                if (utilisateurRepository == null)
                    utilisateurRepository = new GenericRepository<Utilisateur>(_context);
                return utilisateurRepository;
            }
        }

        public IGenericRepository<Ville> VilleRepository
        {
            get
            {
                if (villeRepository == null)
                    villeRepository = new GenericRepository<Ville>(_context);
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
