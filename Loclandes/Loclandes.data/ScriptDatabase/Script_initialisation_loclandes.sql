-- Cr�ation de la base
If DB_ID ('DBLoclandes') is NULL
create database DBLoclandes

USE [DBLoclandes]
GO


-- Mettre la table avec les contraintes en premier pour pouvoir l'effacer
drop table if exists dbo.Etapes_MiniExcursion, dbo.MiniExcursions, dbo.Etapes

-- Version drop sur chaque ligne
--drop table if exists dbo.Etapes_MiniExcursion
--drop table if exists dbo.MiniExcursions
--drop table if exists dbo.Etapes


-- TABLE MiniExcursions
CREATE TABLE [dbo].[MiniExcursions](
	[idMiniExcursion] [int] IDENTITY(1,1) NOT NULL,
	[libelleMiniExcursion] [varchar](255) NOT NULL,
	[nombrePlaceMiniExcursion] [int] NOT NULL,
	--[dureePrevue] [int] NOT NULL, on ne stocke pas cette donn�e l'API la calcule

	-- Cl� primaire
	CONSTRAINT PK_ID_MiniExcursions PRIMARY KEY(idMiniExcursion)
	)
GO


-- TABLE Etapes
CREATE TABLE [dbo].[Etapes](
	[idEtape][int] IDENTITY(1,1) NOT NULL,
	[description][varchar](255) NOT NULL,
	[dureePrevue] [int] NOT NULL,

	-- Cl� primaire
	CONSTRAINT PK_ID_Etapes PRIMARY KEY(idetape)
	)
GO


-- TABLE Etapes_MiniExcursion
CREATE TABLE [dbo].[Etapes_MiniExcursion](
	[idEtape_MiniExcursion][int] IDENTITY(1,1) NOT NULL,
	[idMiniExcursion][int]  NOT NULL,
	[idEtape] [int] NOT NULL,
	[ordreEtape] [int] NOT NULL,

	-- Cl� primaire
	CONSTRAINT PK_ID_Etapes_MiniExcursion PRIMARY KEY(idEtape_MiniExcursion),
	-- Cl�s �trang�res
	CONSTRAINT FK_ID_Etapes_MiniExcursion FOREIGN KEY (idMiniExcursion)
    REFERENCES miniExcursions(idMiniExcursion),
	CONSTRAINT FK_ID_Etape FOREIGN KEY (idEtape)
    REFERENCES etapes(idEtape)
	)
GO


-- Insertion des donn�es : [MiniExcursions]
INSERT INTO [dbo].[MiniExcursions]
           ([libelleMiniExcursion]
           ,[nombrePlaceMiniExcursion])
     VALUES
           ('Visite de la cit� du vin comment�e' , 12),
		   ('Visite du Cap Sciences' , 8)
GO


