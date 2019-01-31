
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/30/2018 21:35:14
-- Generated from EDMX file: C:\Users\Neven\documents\visual studio 2017\Projects\SimpleCRUD\EFModelFirst\CrudModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EFCrud];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'radniks'
CREATE TABLE [dbo].[radniks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ime] nvarchar(max)  NOT NULL,
    [prezime] nvarchar(max)  NOT NULL,
    [maticni] int  NOT NULL,
    [sektorId] int  NOT NULL
);
GO

-- Creating table 'sektors'
CREATE TABLE [dbo].[sektors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [naziv] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'radniks'
ALTER TABLE [dbo].[radniks]
ADD CONSTRAINT [PK_radniks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'sektors'
ALTER TABLE [dbo].[sektors]
ADD CONSTRAINT [PK_sektors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [sektorId] in table 'radniks'
ALTER TABLE [dbo].[radniks]
ADD CONSTRAINT [FK_radniksektor]
    FOREIGN KEY ([sektorId])
    REFERENCES [dbo].[sektors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_radniksektor'
CREATE INDEX [IX_FK_radniksektor]
ON [dbo].[radniks]
    ([sektorId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------