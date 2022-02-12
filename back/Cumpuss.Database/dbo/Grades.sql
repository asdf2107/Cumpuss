CREATE TABLE [dbo].[Grades]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[StudentId] INT NOT NULL,
    [ClassId] INT NOT NULL, 
    [Value] FLOAT NOT NULL, 
    CONSTRAINT [FK_Grades_ToStudents] FOREIGN KEY ([StudentId]) REFERENCES [Students], 
    CONSTRAINT [FK_Grades_ToClasses] FOREIGN KEY ([ClassId]) REFERENCES [Classes],
)
