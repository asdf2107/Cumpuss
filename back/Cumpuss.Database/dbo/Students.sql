CREATE TABLE [dbo].[Students]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[PersonId] INT NOT NULL, 
    [GroupId] INT NOT NULL, 
    CONSTRAINT [FK_Students_ToPersons] FOREIGN KEY ([PersonId]) REFERENCES [Persons], 
    CONSTRAINT [FK_Students_ToGroups] FOREIGN KEY ([GroupId]) REFERENCES [Groups]
)
