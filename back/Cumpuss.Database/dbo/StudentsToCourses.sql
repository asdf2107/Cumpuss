CREATE TABLE [dbo].[StudentsToCourses]
(
	[StudentId] INT NOT NULL,
	[CourseId] INT NOT NULL, 
    PRIMARY KEY ([StudentId], [CourseId]), 
    CONSTRAINT [FK_StudentsToCourses_ToStudents] FOREIGN KEY ([StudentId]) REFERENCES [Students], 
    CONSTRAINT [FK_StudentsToCourses_ToCourses] FOREIGN KEY ([CourseId]) REFERENCES [Courses]
)
