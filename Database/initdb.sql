USE [Pangolin]
GO
/****** Object:  User [PangolinUser]    Script Date: 11-03-20 15:17:37 ******/
CREATE USER [PangolinUser] FOR LOGIN [PangolinUser] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [PangolinUser]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11-03-20 15:17:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Adresse]    Script Date: 11-03-20 15:17:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adresse](
	[Id] [uniqueidentifier] NOT NULL,
	[Rue] [nvarchar](max) NOT NULL,
	[Numero] [nvarchar](max) NOT NULL,
	[Boite] [nvarchar](max) NULL,
	[CodePostal] [nvarchar](max) NOT NULL,
	[VilleId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Adresse] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Commentaire]    Script Date: 11-03-20 15:17:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commentaire](
	[Id] [uniqueidentifier] NOT NULL,
	[DateCreation] [datetime2](7) NOT NULL,
	[Contenu] [nvarchar](max) NOT NULL,
	[TacheId] [uniqueidentifier] NOT NULL,
	[UtilisateurId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Commentaire] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entreprise]    Script Date: 11-03-20 15:17:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entreprise](
	[Id] [uniqueidentifier] NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[Telephone] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[AdresseId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Entreprise] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participant]    Script Date: 11-03-20 15:17:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participant](
	[TacheId] [uniqueidentifier] NOT NULL,
	[UtilisateurId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Participant] PRIMARY KEY CLUSTERED 
(
	[TacheId] ASC,
	[UtilisateurId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Poste]    Script Date: 11-03-20 15:17:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Poste](
	[Id] [uniqueidentifier] NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Poste] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Priorite]    Script Date: 11-03-20 15:17:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Priorite](
	[Id] [uniqueidentifier] NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[Niveau] [int] NOT NULL,
 CONSTRAINT [PK_Priorite] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 11-03-20 15:17:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [uniqueidentifier] NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statut]    Script Date: 11-03-20 15:17:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statut](
	[Id] [uniqueidentifier] NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Statut] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tache]    Script Date: 11-03-20 15:17:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tache](
	[Id] [uniqueidentifier] NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[DateCreation] [datetime2](7) NOT NULL,
	[DateDeadline] [datetime2](7) NULL,
	[DateRealisation] [datetime2](7) NULL,
	[CreateurId] [uniqueidentifier] NOT NULL,
	[PrioriteId] [uniqueidentifier] NOT NULL,
	[StatutId] [uniqueidentifier] NOT NULL,
	[EntrepriseId] [uniqueidentifier] NOT NULL,
	[TypeTacheId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Tache] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeTache]    Script Date: 11-03-20 15:17:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeTache](
	[Id] [uniqueidentifier] NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[ParentId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_TypeTache] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilisateur]    Script Date: 11-03-20 15:17:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilisateur](
	[Id] [uniqueidentifier] NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[Prenom] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](max) NULL,
	[Telephone] [nvarchar](max) NOT NULL,
	[EntrepriseId] [uniqueidentifier] NOT NULL,
	[PosteId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Utilisateur] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UtilisateurRole]    Script Date: 11-03-20 15:17:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UtilisateurRole](
	[UtilisateurId] [uniqueidentifier] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_UtilisateurRole] PRIMARY KEY CLUSTERED 
(
	[UtilisateurId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ville]    Script Date: 11-03-20 15:17:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ville](
	[Id] [uniqueidentifier] NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Ville] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Adresse]  WITH CHECK ADD  CONSTRAINT [FK_Adresse_Ville_VilleId] FOREIGN KEY([VilleId])
REFERENCES [dbo].[Ville] ([Id])
GO
ALTER TABLE [dbo].[Adresse] CHECK CONSTRAINT [FK_Adresse_Ville_VilleId]
GO
ALTER TABLE [dbo].[Commentaire]  WITH CHECK ADD  CONSTRAINT [FK_Commentaire_Tache_TacheId] FOREIGN KEY([TacheId])
REFERENCES [dbo].[Tache] ([Id])
GO
ALTER TABLE [dbo].[Commentaire] CHECK CONSTRAINT [FK_Commentaire_Tache_TacheId]
GO
ALTER TABLE [dbo].[Commentaire]  WITH CHECK ADD  CONSTRAINT [FK_Commentaire_Utilisateur_UtilisateurId] FOREIGN KEY([UtilisateurId])
REFERENCES [dbo].[Utilisateur] ([Id])
GO
ALTER TABLE [dbo].[Commentaire] CHECK CONSTRAINT [FK_Commentaire_Utilisateur_UtilisateurId]
GO
ALTER TABLE [dbo].[Entreprise]  WITH CHECK ADD  CONSTRAINT [FK_Entreprise_Adresse_AdresseId] FOREIGN KEY([AdresseId])
REFERENCES [dbo].[Adresse] ([Id])
GO
ALTER TABLE [dbo].[Entreprise] CHECK CONSTRAINT [FK_Entreprise_Adresse_AdresseId]
GO
ALTER TABLE [dbo].[Participant]  WITH CHECK ADD  CONSTRAINT [FK_Participant_Tache_TacheId] FOREIGN KEY([TacheId])
REFERENCES [dbo].[Tache] ([Id])
GO
ALTER TABLE [dbo].[Participant] CHECK CONSTRAINT [FK_Participant_Tache_TacheId]
GO
ALTER TABLE [dbo].[Participant]  WITH CHECK ADD  CONSTRAINT [FK_Participant_Utilisateur_UtilisateurId] FOREIGN KEY([UtilisateurId])
REFERENCES [dbo].[Utilisateur] ([Id])
GO
ALTER TABLE [dbo].[Participant] CHECK CONSTRAINT [FK_Participant_Utilisateur_UtilisateurId]
GO
ALTER TABLE [dbo].[Tache]  WITH CHECK ADD  CONSTRAINT [FK_Tache_Entreprise_EntrepriseId] FOREIGN KEY([EntrepriseId])
REFERENCES [dbo].[Entreprise] ([Id])
GO
ALTER TABLE [dbo].[Tache] CHECK CONSTRAINT [FK_Tache_Entreprise_EntrepriseId]
GO
ALTER TABLE [dbo].[Tache]  WITH CHECK ADD  CONSTRAINT [FK_Tache_Priorite_PrioriteId] FOREIGN KEY([PrioriteId])
REFERENCES [dbo].[Priorite] ([Id])
GO
ALTER TABLE [dbo].[Tache] CHECK CONSTRAINT [FK_Tache_Priorite_PrioriteId]
GO
ALTER TABLE [dbo].[Tache]  WITH CHECK ADD  CONSTRAINT [FK_Tache_Statut_StatutId] FOREIGN KEY([StatutId])
REFERENCES [dbo].[Statut] ([Id])
GO
ALTER TABLE [dbo].[Tache] CHECK CONSTRAINT [FK_Tache_Statut_StatutId]
GO
ALTER TABLE [dbo].[Tache]  WITH CHECK ADD  CONSTRAINT [FK_Tache_TypeTache_TypeTacheId] FOREIGN KEY([TypeTacheId])
REFERENCES [dbo].[TypeTache] ([Id])
GO
ALTER TABLE [dbo].[Tache] CHECK CONSTRAINT [FK_Tache_TypeTache_TypeTacheId]
GO
ALTER TABLE [dbo].[Tache]  WITH CHECK ADD  CONSTRAINT [FK_Tache_Utilisateur_CreateurId] FOREIGN KEY([CreateurId])
REFERENCES [dbo].[Utilisateur] ([Id])
GO
ALTER TABLE [dbo].[Tache] CHECK CONSTRAINT [FK_Tache_Utilisateur_CreateurId]
GO
ALTER TABLE [dbo].[TypeTache]  WITH CHECK ADD  CONSTRAINT [FK_TypeTache_TypeTache_ParentId] FOREIGN KEY([ParentId])
REFERENCES [dbo].[TypeTache] ([Id])
GO
ALTER TABLE [dbo].[TypeTache] CHECK CONSTRAINT [FK_TypeTache_TypeTache_ParentId]
GO
ALTER TABLE [dbo].[Utilisateur]  WITH CHECK ADD  CONSTRAINT [FK_Utilisateur_Entreprise_EntrepriseId] FOREIGN KEY([EntrepriseId])
REFERENCES [dbo].[Entreprise] ([Id])
GO
ALTER TABLE [dbo].[Utilisateur] CHECK CONSTRAINT [FK_Utilisateur_Entreprise_EntrepriseId]
GO
ALTER TABLE [dbo].[Utilisateur]  WITH CHECK ADD  CONSTRAINT [FK_Utilisateur_Poste_PosteId] FOREIGN KEY([PosteId])
REFERENCES [dbo].[Poste] ([Id])
GO
ALTER TABLE [dbo].[Utilisateur] CHECK CONSTRAINT [FK_Utilisateur_Poste_PosteId]
GO
ALTER TABLE [dbo].[UtilisateurRole]  WITH CHECK ADD  CONSTRAINT [FK_UtilisateurRole_Role_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[UtilisateurRole] CHECK CONSTRAINT [FK_UtilisateurRole_Role_RoleId]
GO
ALTER TABLE [dbo].[UtilisateurRole]  WITH CHECK ADD  CONSTRAINT [FK_UtilisateurRole_Utilisateur_UtilisateurId] FOREIGN KEY([UtilisateurId])
REFERENCES [dbo].[Utilisateur] ([Id])
GO
ALTER TABLE [dbo].[UtilisateurRole] CHECK CONSTRAINT [FK_UtilisateurRole_Utilisateur_UtilisateurId]
GO
