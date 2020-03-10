USE [Pangolin]

SET xact_abort ON
BEGIN TRANSACTION seed_data

GO
INSERT [dbo].[Ville] ([Id], [Nom]) VALUES (N'd29fdda9-05e6-4745-a63c-3b7dccb78376', N'Bruxelles')
GO
INSERT [dbo].[Ville] ([Id], [Nom]) VALUES (N'6263f376-05ed-4a62-b394-dcc64db74094', N'Charleroi')
GO
INSERT [dbo].[Adresse] ([Id], [Rue], [Numero], [Boite], [CodePostal], [VilleId]) VALUES (N'417f63da-4f3b-46fa-a470-246be82089a8', N'Avenue du Port ', N'86C', N'99', N'1000', N'd29fdda9-05e6-4745-a63c-3b7dccb78376')
GO
INSERT [dbo].[Adresse] ([Id], [Rue], [Numero], [Boite], [CodePostal], [VilleId]) VALUES (N'05d65b94-3fe1-4e7e-afe9-7494acbcc405', N'Avenue du champi', N'78', NULL, N'6010', N'6263f376-05ed-4a62-b394-dcc64db74094')
GO
INSERT [dbo].[Entreprise] ([Id], [Nom], [Telephone], [Description], [AdresseId]) VALUES (N'a5de166f-bc73-4ef1-88f8-d1b6c93d55d2', N'Entreprise de Charleroi', N'0477 55 55 55', N'Une super entreprise basée a Charleroi', N'05d65b94-3fe1-4e7e-afe9-7494acbcc405')
GO
INSERT [dbo].[Entreprise] ([Id], [Nom], [Telephone], [Description], [AdresseId]) VALUES (N'981f83a9-fc8a-4ecd-9ec8-dd4f9f141261', N'PermaFungi', N'0478 02 26 78', N'Permafungi est une coopérative à finalité sociale basée à Bruxelles qui recycle un déchet urbain - le marc de café !', N'417f63da-4f3b-46fa-a470-246be82089a8')
GO
INSERT [dbo].[Priorite] ([Id], [Nom], [Niveau]) VALUES (N'58cc9476-0cbd-4a91-a330-1a39497f8c2b', N'haute', 3)
GO
INSERT [dbo].[Priorite] ([Id], [Nom], [Niveau]) VALUES (N'2419e2bd-afc9-44ed-b7da-38dec99beff7', N'basse', 1)
GO
INSERT [dbo].[Statut] ([Id], [Nom]) VALUES (N'a3419a76-b03b-4402-9756-5b4207ef7819', N'En attente')
GO
INSERT [dbo].[Statut] ([Id], [Nom]) VALUES (N'2ebf47b6-fd3a-43a8-a5ae-68cbd1dfbaf1', N'Fini')
GO
INSERT [dbo].[TypeTache] ([Id], [Nom], [Description], [ParentId]) VALUES (N'00c29679-77cc-4019-a8ae-8da596b163d7', N'Production', N'Tout ce qui concerne la production.', NULL)
GO
INSERT [dbo].[TypeTache] ([Id], [Nom], [Description], [ParentId]) VALUES (N'bf39a626-5aa7-4895-9d9e-30c396db2424', N'R&D', N'Recherche et dévellopement', N'00c29679-77cc-4019-a8ae-8da596b163d7')
GO
INSERT [dbo].[Poste] ([Id], [Nom], [Description]) VALUES (N'33ba097c-f90e-4875-8adf-5f7080e3d444', N'Stagiaire', NULL)
GO
INSERT [dbo].[Poste] ([Id], [Nom], [Description]) VALUES (N'b17e617e-d786-4ca5-9294-c0a90e503a77', N'RH', N'Ressources humaines')
GO
INSERT [dbo].[Utilisateur] ([Id], [Nom], [Prenom], [Email], [Password], [Image], [Telephone], [EntrepriseId], [PosteId]) VALUES (N'ad70b45f-09a8-4a5a-8e6f-c46a4530befb', N'Pikachu', N'Michael', N'mike@charleroi.com', N'mike1234', NULL, N'02 758 75 87', N'a5de166f-bc73-4ef1-88f8-d1b6c93d55d2', N'33ba097c-f90e-4875-8adf-5f7080e3d444')
GO
INSERT [dbo].[Utilisateur] ([Id], [Nom], [Prenom], [Email], [Password], [Image], [Telephone], [EntrepriseId], [PosteId]) VALUES (N'3d9f5f9a-05d5-4670-8bd7-dcae752f42ef', N'Remi', N'Nathan', N'test@permafungi.com', N'test1234', NULL, N'0477 00 00 00', N'981f83a9-fc8a-4ecd-9ec8-dd4f9f141261', N'b17e617e-d786-4ca5-9294-c0a90e503a77')
GO
INSERT [dbo].[Tache] ([Id], [Nom], [Description], [DateCreation], [DateDeadline], [CreateurId], [PrioriteId], [StatutId], [EntrepriseId], [TypeTacheId]) VALUES (N'7d3723c4-4878-435f-934f-19528f5543e7', N'Mise a jour donnée réelle', N'Il faut mettre a jour les données réelles dans notre fichier Excelle.', CAST(N'2020-03-07T08:15:00.000' AS DateTime), CAST(N'2020-03-10T00:00:00.000' AS DateTime), N'ad70b45f-09a8-4a5a-8e6f-c46a4530befb', N'2419e2bd-afc9-44ed-b7da-38dec99beff7', N'2ebf47b6-fd3a-43a8-a5ae-68cbd1dfbaf1', N'a5de166f-bc73-4ef1-88f8-d1b6c93d55d2', N'00c29679-77cc-4019-a8ae-8da596b163d7')
GO
INSERT [dbo].[Tache] ([Id], [Nom], [Description], [DateCreation], [DateDeadline], [CreateurId], [PrioriteId], [StatutId], [EntrepriseId], [TypeTacheId]) VALUES (N'43a9659f-17db-4613-aa01-6ad2dbf784b2', N'Réparation frigo', N'Une réparation du frigo qui fuit dans le sous-sol.', CAST(N'2020-03-10T12:24:00.000' AS DateTime), NULL, N'3d9f5f9a-05d5-4670-8bd7-dcae752f42ef', N'58cc9476-0cbd-4a91-a330-1a39497f8c2b', N'a3419a76-b03b-4402-9756-5b4207ef7819', N'981f83a9-fc8a-4ecd-9ec8-dd4f9f141261', N'bf39a626-5aa7-4895-9d9e-30c396db2424')
GO
INSERT [dbo].[Role] ([Id], [Nom], [Description]) VALUES (N'33ba097c-f90e-4875-8adf-5f7080e3d444', N'Employé', N'Role pour les employés.')
GO
INSERT [dbo].[Role] ([Id], [Nom], [Description]) VALUES (N'6d6e2054-05b3-4866-961a-e4c47498d4b3', N'Administrateur', N'Administrateur qui a accès à tout. Modification et vue sur toutes les données.')
GO
INSERT [dbo].[UtilisateurRole] ([UtilisateurId], [RoleId]) VALUES (N'ad70b45f-09a8-4a5a-8e6f-c46a4530befb', N'33ba097c-f90e-4875-8adf-5f7080e3d444')
GO
INSERT [dbo].[UtilisateurRole] ([UtilisateurId], [RoleId]) VALUES (N'3d9f5f9a-05d5-4670-8bd7-dcae752f42ef', N'6d6e2054-05b3-4866-961a-e4c47498d4b3')
GO
INSERT [dbo].[Commentaire] ([Id], [DateCreation], [Contenu], [TacheId], [UtilisateurId]) VALUES (N'3b3172cb-59b6-4479-9123-f3a3fa23d872', CAST(N'2020-03-09T00:00:00.000' AS DateTime), N'Bonjour, ceci est un commentaire constructif pour la tache.', N'7d3723c4-4878-435f-934f-19528f5543e7', N'ad70b45f-09a8-4a5a-8e6f-c46a4530befb')
GO
INSERT [dbo].[Participant] ([TacheId], [UtilisateurId]) VALUES (N'43a9659f-17db-4613-aa01-6ad2dbf784b2', N'3d9f5f9a-05d5-4670-8bd7-dcae752f42ef')
GO

COMMIT TRANSACTION seed_data