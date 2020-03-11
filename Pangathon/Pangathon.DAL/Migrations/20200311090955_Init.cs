using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pangathon.DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Poste",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poste", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Priorite",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: false),
                    Niveau = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorite", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statut",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statut", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeTache",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ParentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeTache", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeTache_TypeTache_ParentId",
                        column: x => x.ParentId,
                        principalTable: "TypeTache",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ville",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ville", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adresse",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Rue = table.Column<string>(nullable: false),
                    Numero = table.Column<string>(nullable: false),
                    Boite = table.Column<string>(nullable: true),
                    CodePostal = table.Column<string>(nullable: false),
                    VilleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adresse_Ville_VilleId",
                        column: x => x.VilleId,
                        principalTable: "Ville",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entreprise",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: false),
                    Telephone = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    AdresseId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entreprise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entreprise_Adresse_AdresseId",
                        column: x => x.AdresseId,
                        principalTable: "Adresse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: false),
                    EntrepriseId = table.Column<Guid>(nullable: false),
                    PosteId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Utilisateur_Entreprise_EntrepriseId",
                        column: x => x.EntrepriseId,
                        principalTable: "Entreprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Utilisateur_Poste_PosteId",
                        column: x => x.PosteId,
                        principalTable: "Poste",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tache",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateDeadline = table.Column<DateTime>(nullable: true),
                    DateRealisation = table.Column<DateTime>(nullable: true),
                    CreateurId = table.Column<Guid>(nullable: false),
                    PrioriteId = table.Column<Guid>(nullable: false),
                    StatutId = table.Column<Guid>(nullable: false),
                    EntrepriseId = table.Column<Guid>(nullable: false),
                    TypeTacheId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tache", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tache_Utilisateur_CreateurId",
                        column: x => x.CreateurId,
                        principalTable: "Utilisateur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tache_Entreprise_EntrepriseId",
                        column: x => x.EntrepriseId,
                        principalTable: "Entreprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tache_Priorite_PrioriteId",
                        column: x => x.PrioriteId,
                        principalTable: "Priorite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tache_Statut_StatutId",
                        column: x => x.StatutId,
                        principalTable: "Statut",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tache_TypeTache_TypeTacheId",
                        column: x => x.TypeTacheId,
                        principalTable: "TypeTache",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UtilisateurRole",
                columns: table => new
                {
                    UtilisateurId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilisateurRole", x => new { x.UtilisateurId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UtilisateurRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UtilisateurRole_Utilisateur_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Commentaire",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    Contenu = table.Column<string>(nullable: false),
                    TacheId = table.Column<Guid>(nullable: false),
                    UtilisateurId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commentaire", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commentaire_Tache_TacheId",
                        column: x => x.TacheId,
                        principalTable: "Tache",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commentaire_Utilisateur_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Participant",
                columns: table => new
                {
                    TacheId = table.Column<Guid>(nullable: false),
                    UtilisateurId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participant", x => new { x.TacheId, x.UtilisateurId });
                    table.ForeignKey(
                        name: "FK_Participant_Tache_TacheId",
                        column: x => x.TacheId,
                        principalTable: "Tache",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participant_Utilisateur_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresse_VilleId",
                table: "Adresse",
                column: "VilleId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentaire_TacheId",
                table: "Commentaire",
                column: "TacheId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentaire_UtilisateurId",
                table: "Commentaire",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Entreprise_AdresseId",
                table: "Entreprise",
                column: "AdresseId");

            migrationBuilder.CreateIndex(
                name: "IX_Participant_UtilisateurId",
                table: "Participant",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Tache_CreateurId",
                table: "Tache",
                column: "CreateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Tache_EntrepriseId",
                table: "Tache",
                column: "EntrepriseId");

            migrationBuilder.CreateIndex(
                name: "IX_Tache_PrioriteId",
                table: "Tache",
                column: "PrioriteId");

            migrationBuilder.CreateIndex(
                name: "IX_Tache_StatutId",
                table: "Tache",
                column: "StatutId");

            migrationBuilder.CreateIndex(
                name: "IX_Tache_TypeTacheId",
                table: "Tache",
                column: "TypeTacheId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeTache_ParentId",
                table: "TypeTache",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateur_EntrepriseId",
                table: "Utilisateur",
                column: "EntrepriseId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateur_PosteId",
                table: "Utilisateur",
                column: "PosteId");

            migrationBuilder.CreateIndex(
                name: "IX_UtilisateurRole_RoleId",
                table: "UtilisateurRole",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commentaire");

            migrationBuilder.DropTable(
                name: "Participant");

            migrationBuilder.DropTable(
                name: "UtilisateurRole");

            migrationBuilder.DropTable(
                name: "Tache");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Utilisateur");

            migrationBuilder.DropTable(
                name: "Priorite");

            migrationBuilder.DropTable(
                name: "Statut");

            migrationBuilder.DropTable(
                name: "TypeTache");

            migrationBuilder.DropTable(
                name: "Entreprise");

            migrationBuilder.DropTable(
                name: "Poste");

            migrationBuilder.DropTable(
                name: "Adresse");

            migrationBuilder.DropTable(
                name: "Ville");
        }
    }
}
