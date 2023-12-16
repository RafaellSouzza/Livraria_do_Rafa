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
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202211412_LivrariaTable')
BEGIN
    CREATE TABLE [Categoria] (
        [Id] int NOT NULL IDENTITY,
        [Nome] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Categoria] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202211412_LivrariaTable')
BEGIN
    CREATE TABLE [Livros] (
        [Id] int NOT NULL IDENTITY,
        [ImagemUrl] nvarchar(max) NOT NULL,
        [Titulo] nvarchar(max) NOT NULL,
        [Descricao] nvarchar(max) NOT NULL,
        [Autor] nvarchar(max) NOT NULL,
        [PrecoNormal] decimal(18,2) NOT NULL,
        [PrecoComDesconto] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_Livros] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202211412_LivrariaTable')
BEGIN
    CREATE TABLE [LivroCategoria] (
        [CategoriaId] int NOT NULL,
        [LivroId] int NOT NULL,
        CONSTRAINT [PK_LivroCategoria] PRIMARY KEY ([LivroId], [CategoriaId]),
        CONSTRAINT [FK_LivroCategoria_Categoria_CategoriaId] FOREIGN KEY ([CategoriaId]) REFERENCES [Categoria] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_LivroCategoria_Livros_LivroId] FOREIGN KEY ([LivroId]) REFERENCES [Livros] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202211412_LivrariaTable')
BEGIN
    CREATE INDEX [IX_LivroCategoria_CategoriaId] ON [LivroCategoria] ([CategoriaId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231202211412_LivrariaTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231202211412_LivrariaTable', N'7.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231216174932_mssql_migration_291')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231216174932_mssql_migration_291', N'7.0.14');
END;
GO

COMMIT;
GO

