using System.Collections.Generic;

namespace Cumpuss.Infrastructure.Models
{
    public partial class Student
    {
        public Student()
        {
            Grades = new HashSet<Grade>();
            StudentsToCourses = new HashSet<StudentsToCourse>();
        }

        public int Id { get; set; }
        public int PersonId { get; set; }
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<StudentsToCourse> StudentsToCourses { get; set; }
    }
}
