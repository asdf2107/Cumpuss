CREATE TABLE [dbo].[Courses]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Year] INT NOT NULL,
    [FirstSemester] BIT NOT NULL,
    [SubjectId] INT NOT NULL, 
    [LecturerId] INT NOT NULL, 
    [PracticeTeacherId] INT NOT NULL, 
    CONSTRAINT [FK_Courses_ToSubjects] FOREIGN KEY ([SubjectId]) REFERENCES [Subjects]([Id]),
    CONSTRAINT [FK_Courses_ToTeachers_Lecturer] FOREIGN KEY ([LecturerId]) REFERENCES [Teachers]([Id]),
    CONSTRAINT [FK_Courses_ToTeachers_PracticeTeacher] FOREIGN KEY ([PracticeTeacherId]) REFERENCES [Teachers]([Id])
)
