using Microsoft.EntityFrameworkCore;
using Pangathon.DAL.Entities;
using System;
using System.Linq;

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
                //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PangathonTest;Trusted_Connection=True;");
                optionsBuilder.UseSqlServer(@"Server=192.168.0.100\HACKATHON;Database=Pangolin;user id=PangolinUser;password=PangolinUser;");
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder is null)
                throw new ArgumentNullException(nameof(modelBuilder));

            // Disable cascade delete globally
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            // Table de jointure Participant
            modelBuilder.Entity<Participant>().HasKey(p => new { p.TacheId, p.UtilisateurId });

            modelBuilder.Entity<Participant>()
                .HasOne<Tache>(Participant => Participant.Tache)
                .WithMany(Tache => Tache.Participants)
                .HasForeignKey(Participant => Participant.TacheId);

            modelBuilder.Entity<Participant>()
                .HasOne<Utilisateur>(Participant => Participant.Utilisateur)
                .WithMany(Utilisateur => Utilisateur.Participations)
                .HasForeignKey(Participant => Participant.UtilisateurId);

            // Table de jointure UtilisateurRole
            modelBuilder.Entity<UtilisateurRole>().HasKey(ur => new { ur.UtilisateurId, ur.RoleId });

            modelBuilder.Entity<UtilisateurRole>()
                .HasOne<Utilisateur>(UtilisateurRole => UtilisateurRole.Utilisateur)
                .WithMany(Utilisateur => Utilisateur.UtilisateurRoles)
                .HasForeignKey(UtilisateurRole => UtilisateurRole.UtilisateurId);

            modelBuilder.Entity<UtilisateurRole>()
                .HasOne<Role>(UtilisateurRole => UtilisateurRole.Role)
                .WithMany(Role => Role.UtilisateurRoles)
                .HasForeignKey(UtilisateurRole => UtilisateurRole.RoleId);
        }

        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Commentaire> Commentaires { get; set; }
        public DbSet<Entreprise> Entreprises { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Poste> Postes { get; set; }
        public DbSet<Priorite> Priorites { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Statut> Statuts { get; set; }
        public DbSet<Tache> Taches { get; set; }
        public DbSet<TypeTache> TypeTaches { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<UtilisateurRole> UtilisateurRoles { get; set; }
        public DbSet<Ville> Villes { get; set; }
    }
}
