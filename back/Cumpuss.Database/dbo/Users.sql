CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PersonId] INT NOT NULL, 
    [Username] VARCHAR(20) NOT NULL, 
    [PasswordHash] VARCHAR(255) NOT NULL, 
    [UserType] INT NOT NULL , 
    CONSTRAINT [FK_Users_ToPersons] FOREIGN KEY ([PersonId]) REFERENCES [Persons],
    CONSTRAINT UC_Users_Username UNIQUE (Username)
)
