﻿CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FaceId] INT NOT NULL, 
    [Login] NCHAR(20) NOT NULL, 
    [PasswordHash] NCHAR(255) NOT NULL, 
    [UserType] SMALLINT NOT NULL , 
    CONSTRAINT [FK_Users_ToFaces] FOREIGN KEY ([FaceId]) REFERENCES [Persons]
)