CREATE TABLE [dbo].[Persons]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(20) NOT NULL, 
    [Sirname] NVARCHAR(30) NOT NULL, 
    [Patronymic] NVARCHAR(30) NULL, 
    [Email] VARCHAR(100) NULL
)
