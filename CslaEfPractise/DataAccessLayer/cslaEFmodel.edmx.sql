
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/08/2017 04:45:37
-- Generated from EDMX file: C:\Users\Neven\Desktop\Projekti\cslaNevenEF\DataAccessLayer\cslaEFmodel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [cslaEF];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FondArtikl]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Artikls] DROP CONSTRAINT [FK_FondArtikl];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Artikls]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Artikls];
GO
IF OBJECT_ID(N'[dbo].[Fonds]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fonds];
GO
IF OBJECT_ID(N'[dbo].[Mjestas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mjestas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Artikls'
CREATE TABLE [dbo].[Artikls] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [sifraArtikl] int  NOT NULL,
    [nazivArtikl] nvarchar(max)  NOT NULL,
    [FondId] int  NOT NULL
);
GO

-- Creating table 'Fonds'
CREATE TABLE [dbo].[Fonds] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [sifraFond] nvarchar(max)  NOT NULL,
    [nazivFond] nvarchar(max)  NOT NULL,
    [Aktivan] bit  NOT NULL
);
GO

-- Creating table 'Mjestas'
CREATE TABLE [dbo].[Mjestas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nazivMjesta] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Artikls'
ALTER TABLE [dbo].[Artikls]
ADD CONSTRAINT [PK_Artikls]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Fonds'
ALTER TABLE [dbo].[Fonds]
ADD CONSTRAINT [PK_Fonds]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Mjestas'
ALTER TABLE [dbo].[Mjestas]
ADD CONSTRAINT [PK_Mjestas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FondId] in table 'Artikls'
ALTER TABLE [dbo].[Artikls]
ADD CONSTRAINT [FK_FondArtikl]
    FOREIGN KEY ([FondId])
    REFERENCES [dbo].[Fonds]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FondArtikl'
CREATE INDEX [IX_FK_FondArtikl]
ON [dbo].[Artikls]
    ([FondId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------