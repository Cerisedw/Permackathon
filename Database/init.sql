USE [pangolin]
GO
/****** Object:  Table [dbo].[Adresse]    Script Date: 10-03-20 09:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adresse](
	[idAdresse] [uniqueidentifier] NOT NULL,
	[rue] [nvarchar](300) NOT NULL,
	[numero] [varchar](50) NOT NULL,
	[boite] [varchar](50) NULL,
	[codePostal] [varchar](50) NOT NULL,
	[idVille] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Adresse] PRIMARY KEY CLUSTERED 
(
	[idAdresse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Commentaire]    Script Date: 10-03-20 09:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commentaire](
	[idCommentaire] [uniqueidentifier] NOT NULL,
	[dateCreation] [datetime] NOT NULL,
	[contenu] [nvarchar](max) NOT NULL,
	[idTache] [uniqueidentifier] NOT NULL,
	[idUtilisateur] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Commentaire] PRIMARY KEY CLUSTERED 
(
	[idCommentaire] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entreprise]    Script Date: 10-03-20 09:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entreprise](
	[idEntreprise] [uniqueidentifier] NOT NULL,
	[nom] [nvarchar](200) NOT NULL,
	[telephone] [nvarchar](50) NOT NULL,
	[description] [nvarchar](max) NULL,
	[idAdresse] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Entreprise] PRIMARY KEY CLUSTERED 
(
	[idEntreprise] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participant]    Script Date: 10-03-20 09:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participant](
	[idTache] [uniqueidentifier] NOT NULL,
	[idUtilisateur] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Participant] PRIMARY KEY CLUSTERED 
(
	[idTache] ASC,
	[idUtilisateur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Poste]    Script Date: 10-03-20 09:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Poste](
	[idPoste] [uniqueidentifier] NOT NULL,
	[nom] [nvarchar](100) NOT NULL,
	[description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Poste] PRIMARY KEY CLUSTERED 
(
	[idPoste] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Priorite]    Script Date: 10-03-20 09:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Priorite](
	[idPriorite] [uniqueidentifier] NOT NULL,
	[nom] [nvarchar](100) NOT NULL,
	[niveau] [int] NOT NULL,
 CONSTRAINT [PK_Priorite] PRIMARY KEY CLUSTERED 
(
	[idPriorite] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 10-03-20 09:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[idRole] [uniqueidentifier] NOT NULL,
	[nom] [nvarchar](50) NOT NULL,
	[description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[idRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statut]    Script Date: 10-03-20 09:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statut](
	[idStatut] [uniqueidentifier] NOT NULL,
	[nom] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Statut] PRIMARY KEY CLUSTERED 
(
	[idStatut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tache]    Script Date: 10-03-20 09:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tache](
	[idTache] [uniqueidentifier] NOT NULL,
	[nom] [nvarchar](300) NOT NULL,
	[description] [nvarchar](300) NOT NULL,
	[dateCreation] [datetime] NOT NULL,
	[dateDeadline] [datetime] NULL,
	[idCreateur] [uniqueidentifier] NOT NULL,
	[idPriorite] [uniqueidentifier] NOT NULL,
	[idStatut] [uniqueidentifier] NOT NULL,
	[idEntreprise] [uniqueidentifier] NOT NULL,
	[idType] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Tache] PRIMARY KEY CLUSTERED 
(
	[idTache] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 10-03-20 09:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[idType] [uniqueidentifier] NOT NULL,
	[nom] [nvarchar](100) NOT NULL,
	[description] [nvarchar](max) NULL,
	[idParent] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[idType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilisateur]    Script Date: 10-03-20 09:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilisateur](
	[idUtilisateur] [uniqueidentifier] NOT NULL,
	[nom] [nvarchar](100) NOT NULL,
	[prenom] [nvarchar](50) NOT NULL,
	[email] [nvarchar](350) NOT NULL,
	[password] [varchar](300) NOT NULL,
	[image] [nvarchar](300) NULL,
	[telephone] [varchar](50) NOT NULL,
	[idEntreprise] [uniqueidentifier] NOT NULL,
	[idPoste] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Utilisateur] PRIMARY KEY CLUSTERED 
(
	[idUtilisateur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UtilisateurRole]    Script Date: 10-03-20 09:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UtilisateurRole](
	[idUtilisateur] [uniqueidentifier] NOT NULL,
	[idRole] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_UtilisateurRole] PRIMARY KEY CLUSTERED 
(
	[idUtilisateur] ASC,
	[idRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ville]    Script Date: 10-03-20 09:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ville](
	[idVille] [uniqueidentifier] NOT NULL,
	[nom] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_Ville] PRIMARY KEY CLUSTERED 
(
	[idVille] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Adresse]  WITH CHECK ADD  CONSTRAINT [FK_Adresse_Ville] FOREIGN KEY([idVille])
REFERENCES [dbo].[Ville] ([idVille])
GO
ALTER TABLE [dbo].[Adresse] CHECK CONSTRAINT [FK_Adresse_Ville]
GO
ALTER TABLE [dbo].[Commentaire]  WITH CHECK ADD  CONSTRAINT [FK_Commentaire_Tache] FOREIGN KEY([idTache])
REFERENCES [dbo].[Tache] ([idTache])
GO
ALTER TABLE [dbo].[Commentaire] CHECK CONSTRAINT [FK_Commentaire_Tache]
GO
ALTER TABLE [dbo].[Commentaire]  WITH CHECK ADD  CONSTRAINT [FK_Commentaire_Utilisateur] FOREIGN KEY([idUtilisateur])
REFERENCES [dbo].[Utilisateur] ([idUtilisateur])
GO
ALTER TABLE [dbo].[Commentaire] CHECK CONSTRAINT [FK_Commentaire_Utilisateur]
GO
ALTER TABLE [dbo].[Entreprise]  WITH CHECK ADD  CONSTRAINT [FK_Entreprise_Adresse] FOREIGN KEY([idAdresse])
REFERENCES [dbo].[Adresse] ([idAdresse])
GO
ALTER TABLE [dbo].[Entreprise] CHECK CONSTRAINT [FK_Entreprise_Adresse]
GO
ALTER TABLE [dbo].[Participant]  WITH CHECK ADD  CONSTRAINT [FK_Participant_Tache] FOREIGN KEY([idTache])
REFERENCES [dbo].[Tache] ([idTache])
GO
ALTER TABLE [dbo].[Participant] CHECK CONSTRAINT [FK_Participant_Tache]
GO
ALTER TABLE [dbo].[Participant]  WITH CHECK ADD  CONSTRAINT [FK_Participant_Utilisateur] FOREIGN KEY([idUtilisateur])
REFERENCES [dbo].[Utilisateur] ([idUtilisateur])
GO
ALTER TABLE [dbo].[Participant] CHECK CONSTRAINT [FK_Participant_Utilisateur]
GO
ALTER TABLE [dbo].[Tache]  WITH CHECK ADD  CONSTRAINT [FK_Tache_Entreprise] FOREIGN KEY([idEntreprise])
REFERENCES [dbo].[Entreprise] ([idEntreprise])
GO
ALTER TABLE [dbo].[Tache] CHECK CONSTRAINT [FK_Tache_Entreprise]
GO
ALTER TABLE [dbo].[Tache]  WITH CHECK ADD  CONSTRAINT [FK_Tache_Priorite] FOREIGN KEY([idPriorite])
REFERENCES [dbo].[Priorite] ([idPriorite])
GO
ALTER TABLE [dbo].[Tache] CHECK CONSTRAINT [FK_Tache_Priorite]
GO
ALTER TABLE [dbo].[Tache]  WITH CHECK ADD  CONSTRAINT [FK_Tache_Statut] FOREIGN KEY([idStatut])
REFERENCES [dbo].[Statut] ([idStatut])
GO
ALTER TABLE [dbo].[Tache] CHECK CONSTRAINT [FK_Tache_Statut]
GO
ALTER TABLE [dbo].[Tache]  WITH CHECK ADD  CONSTRAINT [FK_Tache_Type] FOREIGN KEY([idType])
REFERENCES [dbo].[Type] ([idType])
GO
ALTER TABLE [dbo].[Tache] CHECK CONSTRAINT [FK_Tache_Type]
GO
ALTER TABLE [dbo].[Tache]  WITH CHECK ADD  CONSTRAINT [FK_Tache_Utilisateur] FOREIGN KEY([idCreateur])
REFERENCES [dbo].[Utilisateur] ([idUtilisateur])
GO
ALTER TABLE [dbo].[Tache] CHECK CONSTRAINT [FK_Tache_Utilisateur]
GO
ALTER TABLE [dbo].[Type]  WITH CHECK ADD  CONSTRAINT [FK_Type_Type] FOREIGN KEY([idParent])
REFERENCES [dbo].[Type] ([idType])
GO
ALTER TABLE [dbo].[Type] CHECK CONSTRAINT [FK_Type_Type]
GO
ALTER TABLE [dbo].[Utilisateur]  WITH CHECK ADD  CONSTRAINT [FK_Utilisateur_Entreprise] FOREIGN KEY([idEntreprise])
REFERENCES [dbo].[Entreprise] ([idEntreprise])
GO
ALTER TABLE [dbo].[Utilisateur] CHECK CONSTRAINT [FK_Utilisateur_Entreprise]
GO
ALTER TABLE [dbo].[Utilisateur]  WITH CHECK ADD  CONSTRAINT [FK_Utilisateur_Poste] FOREIGN KEY([idPoste])
REFERENCES [dbo].[Poste] ([idPoste])
GO
ALTER TABLE [dbo].[Utilisateur] CHECK CONSTRAINT [FK_Utilisateur_Poste]
GO
ALTER TABLE [dbo].[UtilisateurRole]  WITH CHECK ADD  CONSTRAINT [FK_UtilisateurRole_Role] FOREIGN KEY([idRole])
REFERENCES [dbo].[Role] ([idRole])
GO
ALTER TABLE [dbo].[UtilisateurRole] CHECK CONSTRAINT [FK_UtilisateurRole_Role]
GO
ALTER TABLE [dbo].[UtilisateurRole]  WITH CHECK ADD  CONSTRAINT [FK_UtilisateurRole_Utilisateur] FOREIGN KEY([idUtilisateur])
REFERENCES [dbo].[Utilisateur] ([idUtilisateur])
GO
ALTER TABLE [dbo].[UtilisateurRole] CHECK CONSTRAINT [FK_UtilisateurRole_Utilisateur]
GO
