CREATE TABLE [dbo].[Teachers]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PersonId] INT NOT NULL, 
    CONSTRAINT [FK_Teachers_ToPersons] FOREIGN KEY ([PersonId]) REFERENCES [Persons]
)
