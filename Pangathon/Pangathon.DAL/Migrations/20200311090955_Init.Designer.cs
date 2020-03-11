﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pangathon.DAL;

namespace Pangathon.DAL.Migrations
{
    [DbContext(typeof(PangathonContext))]
    [Migration("20200311090955_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pangathon.DAL.Entities.Adresse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Boite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodePostal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VilleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VilleId");

                    b.ToTable("Adresse");
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.Commentaire", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Contenu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TacheId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UtilisateurId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TacheId");

                    b.HasIndex("UtilisateurId");

                    b.ToTable("Commentaire");
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.Entreprise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdresseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdresseId");

                    b.ToTable("Entreprise");
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.Participant", b =>
                {
                    b.Property<Guid>("TacheId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UtilisateurId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TacheId", "UtilisateurId");

                    b.HasIndex("UtilisateurId");

                    b.ToTable("Participant");
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.Poste", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Poste");
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.Priorite", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Niveau")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Priorite");
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.Statut", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Statut");
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.Tache", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreateurId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeadline")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateRealisation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EntrepriseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PrioriteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StatutId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TypeTacheId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreateurId");

                    b.HasIndex("EntrepriseId");

                    b.HasIndex("PrioriteId");

                    b.HasIndex("StatutId");

                    b.HasIndex("TypeTacheId");

                    b.ToTable("Tache");
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.TypeTache", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("TypeTache");
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.Utilisateur", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EntrepriseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PosteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EntrepriseId");

                    b.HasIndex("PosteId");

                    b.ToTable("Utilisateur");
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.UtilisateurRole", b =>
                {
                    b.Property<Guid>("UtilisateurId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UtilisateurId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UtilisateurRole");
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.Ville", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ville");
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.Adresse", b =>
                {
                    b.HasOne("Pangathon.DAL.Entities.Ville", "Ville")
                        .WithMany()
                        .HasForeignKey("VilleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.Commentaire", b =>
                {
                    b.HasOne("Pangathon.DAL.Entities.Tache", "Tache")
                        .WithMany("Commentaires")
                        .HasForeignKey("TacheId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Pangathon.DAL.Entities.Utilisateur", "Utilisateur")
                        .WithMany()
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.Entreprise", b =>
                {
                    b.HasOne("Pangathon.DAL.Entities.Adresse", "Adresse")
                        .WithMany()
                        .HasForeignKey("AdresseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.Participant", b =>
                {
                    b.HasOne("Pangathon.DAL.Entities.Tache", "Tache")
                        .WithMany("Participants")
                        .HasForeignKey("TacheId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Pangathon.DAL.Entities.Utilisateur", "Utilisateur")
                        .WithMany("Participations")
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.Tache", b =>
                {
                    b.HasOne("Pangathon.DAL.Entities.Utilisateur", "Createur")
                        .WithMany()
                        .HasForeignKey("CreateurId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Pangathon.DAL.Entities.Entreprise", "Entreprise")
                        .WithMany()
                        .HasForeignKey("EntrepriseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Pangathon.DAL.Entities.Priorite", "Priorite")
                        .WithMany()
                        .HasForeignKey("PrioriteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Pangathon.DAL.Entities.Statut", "Statut")
                        .WithMany()
                        .HasForeignKey("StatutId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Pangathon.DAL.Entities.TypeTache", "TypeTache")
                        .WithMany()
                        .HasForeignKey("TypeTacheId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.TypeTache", b =>
                {
                    b.HasOne("Pangathon.DAL.Entities.TypeTache", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.Utilisateur", b =>
                {
                    b.HasOne("Pangathon.DAL.Entities.Entreprise", "Entreprise")
                        .WithMany()
                        .HasForeignKey("EntrepriseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Pangathon.DAL.Entities.Poste", "Poste")
                        .WithMany()
                        .HasForeignKey("PosteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Pangathon.DAL.Entities.UtilisateurRole", b =>
                {
                    b.HasOne("Pangathon.DAL.Entities.Role", "Role")
                        .WithMany("UtilisateurRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Pangathon.DAL.Entities.Utilisateur", "Utilisateur")
                        .WithMany("UtilisateurRoles")
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
