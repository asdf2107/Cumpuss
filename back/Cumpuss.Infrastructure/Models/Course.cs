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
        public int TeacherId { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<GroupsToCourse> GroupsToCourses { get; set; }
        public virtual ICollection<StudentsToCourse> StudentsToCourses { get; set; }
    }
}
