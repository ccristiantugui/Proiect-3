
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/07/2020 01:16:45
-- Generated from EDMX file: E:\Cristian\.Net\Proiect 2\Proiect 2\WCF\Media.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Media];
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

-- Creating table 'Media'
CREATE TABLE [dbo].[Media] (
    [MediaID] int IDENTITY(1,1) NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [MediaType] int  NOT NULL,
    [CreatedAt] datetime  NOT NULL,
    [ModifiedAt] datetime  NOT NULL,
    [LocationLocationID] int  NOT NULL,
    [EventEventID] int  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [LocationID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [PersonID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [EventID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CustomAttributes'
CREATE TABLE [dbo].[CustomAttributes] (
    [CustomAttributeID] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MediaPerson'
CREATE TABLE [dbo].[MediaPerson] (
    [Media_MediaID] int  NOT NULL,
    [People_PersonID] int  NOT NULL
);
GO

-- Creating table 'MediaCustomAttributes'
CREATE TABLE [dbo].[MediaCustomAttributes] (
    [Media_MediaID] int  NOT NULL,
    [CustomAttributes_CustomAttributeID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MediaID] in table 'Media'
ALTER TABLE [dbo].[Media]
ADD CONSTRAINT [PK_Media]
    PRIMARY KEY CLUSTERED ([MediaID] ASC);
GO

-- Creating primary key on [LocationID] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([LocationID] ASC);
GO

-- Creating primary key on [PersonID] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([PersonID] ASC);
GO

-- Creating primary key on [EventID] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([EventID] ASC);
GO

-- Creating primary key on [CustomAttributeID] in table 'CustomAttributes'
ALTER TABLE [dbo].[CustomAttributes]
ADD CONSTRAINT [PK_CustomAttributes]
    PRIMARY KEY CLUSTERED ([CustomAttributeID] ASC);
GO

-- Creating primary key on [Media_MediaID], [People_PersonID] in table 'MediaPerson'
ALTER TABLE [dbo].[MediaPerson]
ADD CONSTRAINT [PK_MediaPerson]
    PRIMARY KEY CLUSTERED ([Media_MediaID], [People_PersonID] ASC);
GO

-- Creating primary key on [Media_MediaID], [CustomAttributes_CustomAttributeID] in table 'MediaCustomAttributes'
ALTER TABLE [dbo].[MediaCustomAttributes]
ADD CONSTRAINT [PK_MediaCustomAttributes]
    PRIMARY KEY CLUSTERED ([Media_MediaID], [CustomAttributes_CustomAttributeID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [LocationLocationID] in table 'Media'
ALTER TABLE [dbo].[Media]
ADD CONSTRAINT [FK_LocationMedia]
    FOREIGN KEY ([LocationLocationID])
    REFERENCES [dbo].[Locations]
        ([LocationID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LocationMedia'
CREATE INDEX [IX_FK_LocationMedia]
ON [dbo].[Media]
    ([LocationLocationID]);
GO

-- Creating foreign key on [EventEventID] in table 'Media'
ALTER TABLE [dbo].[Media]
ADD CONSTRAINT [FK_EventMedia]
    FOREIGN KEY ([EventEventID])
    REFERENCES [dbo].[Events]
        ([EventID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventMedia'
CREATE INDEX [IX_FK_EventMedia]
ON [dbo].[Media]
    ([EventEventID]);
GO

-- Creating foreign key on [Media_MediaID] in table 'MediaPerson'
ALTER TABLE [dbo].[MediaPerson]
ADD CONSTRAINT [FK_MediaPerson_Media]
    FOREIGN KEY ([Media_MediaID])
    REFERENCES [dbo].[Media]
        ([MediaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [People_PersonID] in table 'MediaPerson'
ALTER TABLE [dbo].[MediaPerson]
ADD CONSTRAINT [FK_MediaPerson_Person]
    FOREIGN KEY ([People_PersonID])
    REFERENCES [dbo].[People]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediaPerson_Person'
CREATE INDEX [IX_FK_MediaPerson_Person]
ON [dbo].[MediaPerson]
    ([People_PersonID]);
GO

-- Creating foreign key on [Media_MediaID] in table 'MediaCustomAttributes'
ALTER TABLE [dbo].[MediaCustomAttributes]
ADD CONSTRAINT [FK_MediaCustomAttributes_Media]
    FOREIGN KEY ([Media_MediaID])
    REFERENCES [dbo].[Media]
        ([MediaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CustomAttributes_CustomAttributeID] in table 'MediaCustomAttributes'
ALTER TABLE [dbo].[MediaCustomAttributes]
ADD CONSTRAINT [FK_MediaCustomAttributes_CustomAttributes]
    FOREIGN KEY ([CustomAttributes_CustomAttributeID])
    REFERENCES [dbo].[CustomAttributes]
        ([CustomAttributeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediaCustomAttributes_CustomAttributes'
CREATE INDEX [IX_FK_MediaCustomAttributes_CustomAttributes]
ON [dbo].[MediaCustomAttributes]
    ([CustomAttributes_CustomAttributeID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------