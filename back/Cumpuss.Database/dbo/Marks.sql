CREATE TABLE [dbo].[Marks]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[StudentId] INT NOT NULL,
    [ClassId] INT NOT NULL, 
    [Value] FLOAT NOT NULL, 
    CONSTRAINT [FK_Marks_ToStudents] FOREIGN KEY ([StudentId]) REFERENCES [Students], 
    CONSTRAINT [FK_Marks_ToClasses] FOREIGN KEY ([ClassId]) REFERENCES [Classes],
)
