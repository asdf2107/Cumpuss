CREATE TABLE [dbo].[GroupsToCourses]
(
	[GroupId] INT NOT NULL,
    [CourseId] INT NOT NULL,
	PRIMARY KEY ([GroupId], [CourseId]),
	CONSTRAINT [FK_GroupsToCourses_ToGroups] FOREIGN KEY ([GroupId]) REFERENCES [Groups], 
    CONSTRAINT [FK_GroupsToCourses_ToCourses] FOREIGN KEY ([CourseId]) REFERENCES [Courses]
)
