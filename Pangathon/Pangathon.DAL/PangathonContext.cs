using Microsoft.EntityFrameworkCore;
using Pangathon.DAL.Entities;
using System;

namespace Pangathon.DAL
{
    public class PangathonContext : DbContext
    {
        public PangathonContext()
        { }
        public PangathonContext(DbContextOptions<PangathonContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder is null)
                throw new ArgumentNullException(nameof(optionsBuilder));

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=pangolinTest;Trusted_Connection=True;");
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder is null)
                throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.Entity<Participant>().HasKey(p => new { p.IdTache, p.IdUtilisateur });

            modelBuilder.Entity<Participant>()
                .HasOne<Tache>(Participant => Participant.Tache)
                .WithMany(Tache => Tache.Participants)
                .HasForeignKey(Participant => Participant.IdTache);

            modelBuilder.Entity<Participant>()
                .HasOne<Utilisateur>(Participant => Participant.Utilisateur)
                .WithMany(Utilisateur => Utilisateur.Participations)
                .HasForeignKey(Participant => Participant.IdUtilisateur);
        }

        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Commentaire> Commentaires { get; set; }
        public DbSet<Entreprise> Entreprises { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Poste> Postes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Statut> Statuts { get; set; }
        public DbSet<Tache> Taches { get; set; }
        public DbSet<TypeTache> TypeTaches { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<UtilisateurRole> UtilisateurRoles { get; set; }
        public DbSet<Ville> Villes { get; set; }
    }
}
