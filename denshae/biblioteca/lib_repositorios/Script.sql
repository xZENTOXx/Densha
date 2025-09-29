CREATE DATABASE db_biblioteca;
GO
USE db_biblioteca
GO

CREATE TABLE [Libros] (
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[ISBN] NVARCHAR(50) NOT NULL,
	[Nombre] NVARCHAR(50) NOT NULL,
	[Autor] NVARCHAR(50) NOT NULL,
	[Fecha] SMALLDATETIME NOT NULL DEFAULT GETDATE(),
);
GO

INSERT INTO [Libros] ([ISBN], [Nombre], [Autor], [Fecha])
VALUES ('6574654', 'Programación para dummies', 'Pepito Perez', GETDATE());
GO 
