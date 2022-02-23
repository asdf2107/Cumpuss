using System.Collections.Generic;

namespace Cumpuss.Infrastructure.Models
{
    public partial class Course
    {
        public Course()
        {
            Classes = new HashSet<Class>();
            GroupsToCourses = new HashSet<GroupsToCourse>();
            StudentsToCourses = new HashSet<StudentsToCourse>();
        }

        public int Id { get; set; }
        public int Year { get; set; }
        public bool FirstSemester { get; set; }
        public int SubjectId { get; set; }
        public int LecturerId { get; set; }
        public int PracticeTeacherId { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<GroupsToCourse> GroupsToCourses { get; set; }
        public virtual ICollection<StudentsToCourse> StudentsToCourses { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Teacher Lecturer { get; set; }
        public virtual Teacher PracticeTeacher { get; set; }
    }
}
