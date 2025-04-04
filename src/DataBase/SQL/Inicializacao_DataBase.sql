﻿CREATE DATABASE Tenant02;
GO

USE Tenant02;
GO

IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [Departamentos] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] varchar(60) NOT NULL,
    CONSTRAINT [PK_Departamentos] PRIMARY KEY ([Id])
);

CREATE TABLE [Pessoas] (
    [Id] uniqueidentifier NOT NULL,
    [DepartamentoId] uniqueidentifier NULL,
    [Nome] varchar(60) NOT NULL,
    [SobreNome] varchar(60) NOT NULL,
    [Idade] integer NOT NULL,
    CONSTRAINT [PK_Pessoas] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Pessoas_Departamentos_DepartamentoId] FOREIGN KEY ([DepartamentoId]) REFERENCES [Departamentos] ([Id])
);

CREATE INDEX [IX_Pessoas_DepartamentoId] ON [Pessoas] ([DepartamentoId]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250331120237_Inicializacao_DataBase', N'9.0.3');

COMMIT;
GO