GO
CREATE DATABASE db_partidos
GO
CREATE TABLE Equipos
(
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Nombre] NVARCHAR(50) NOT NULL,
	[Ciudad] NVARCHAR(50) NOT NULL,  
);

CREATE TABLE Jugadores
(
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Nombre] NVARCHAR(100) NOT NULL,
	[Equipo] INT NOT NULL REFERENCES [Equipos] ([Id]),  
	[Fecha] SMALLDATETIME NOT NULL DEFAULT GETDATE(),
	[Activo] BIT NOT NULL,
	[Estatura] DECIMAL (10,2) NOT NULL,


);
GO

INSERT INTO [Equipos] VALUES ('Real Madrid', 'Madrid')
INSERT INTO [Equipos] VALUES ('Barcelona', 'Barcelona')
INSERT INTO [Equipos] VALUES ('Atletico de Madrid', 'Madrid')
INSERT INTO [Jugadores] ([Nombre],[Equipo],[Activo],[Estatura]) VALUES ('Vinicius', 1, 1, 1.70)
GO

SELECT * FROM [Equipos]
SELECT * FROM [Jugadores]

SELECT *
FROM [Jugadores] j INNER JOIN [Equipos] e
	ON e.Id = j.[Equipo];
GO