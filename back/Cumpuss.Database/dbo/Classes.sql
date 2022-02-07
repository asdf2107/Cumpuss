CREATE TABLE [dbo].[Classes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CourseId] INT NOT NULL,
    [Date] DATE NOT NULL, 
    [ClassType] INT NOT NULL, 
    [CustomCaption] NVARCHAR(20) NULL, 
    CONSTRAINT [FK_Classes_ToCourses] FOREIGN KEY ([CourseId]) REFERENCES [Courses]
)
