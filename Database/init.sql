USE [master]
GO
/****** Object:  Database [pangolin]    Script Date: 09-03-20 15:29:07 ******/
CREATE DATABASE [pangolin]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Permackathon', FILENAME = N'C:\Users\dotnet\Permackathon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Permackathon_log', FILENAME = N'C:\Users\dotnet\Permackathon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [pangolin] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pangolin].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pangolin] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pangolin] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pangolin] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pangolin] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pangolin] SET ARITHABORT OFF 
GO
ALTER DATABASE [pangolin] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [pangolin] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pangolin] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pangolin] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pangolin] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pangolin] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pangolin] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pangolin] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pangolin] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pangolin] SET  DISABLE_BROKER 
GO
ALTER DATABASE [pangolin] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pangolin] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pangolin] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pangolin] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pangolin] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pangolin] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [pangolin] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pangolin] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [pangolin] SET  MULTI_USER 
GO
ALTER DATABASE [pangolin] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pangolin] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pangolin] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pangolin] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [pangolin] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [pangolin] SET QUERY_STORE = OFF
GO
USE [pangolin]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [pangolin]
GO
/****** Object:  Table [dbo].[Adresse]    Script Date: 09-03-20 15:29:08 ******/
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
/****** Object:  Table [dbo].[Commentaire]    Script Date: 09-03-20 15:29:08 ******/
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
/****** Object:  Table [dbo].[Entreprise]    Script Date: 09-03-20 15:29:08 ******/
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
/****** Object:  Table [dbo].[Participant]    Script Date: 09-03-20 15:29:08 ******/
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
/****** Object:  Table [dbo].[Poste]    Script Date: 09-03-20 15:29:08 ******/
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
/****** Object:  Table [dbo].[Priorite]    Script Date: 09-03-20 15:29:08 ******/
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
/****** Object:  Table [dbo].[Role]    Script Date: 09-03-20 15:29:08 ******/
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
/****** Object:  Table [dbo].[Statut]    Script Date: 09-03-20 15:29:08 ******/
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
/****** Object:  Table [dbo].[Tache]    Script Date: 09-03-20 15:29:08 ******/
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
/****** Object:  Table [dbo].[Type]    Script Date: 09-03-20 15:29:08 ******/
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
/****** Object:  Table [dbo].[Utilisateur]    Script Date: 09-03-20 15:29:08 ******/
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
/****** Object:  Table [dbo].[UtilisateurRole]    Script Date: 09-03-20 15:29:08 ******/
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
/****** Object:  Table [dbo].[Ville]    Script Date: 09-03-20 15:29:08 ******/
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
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Utilisateur_email]    Script Date: 09-03-20 15:29:08 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Utilisateur_email] ON [dbo].[Utilisateur]
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
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
USE [master]
GO
ALTER DATABASE [pangolin] SET  READ_WRITE 
GO
