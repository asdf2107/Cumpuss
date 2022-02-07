using System.Collections.Generic;

namespace Cumpuss.Infrastructure.Models
{
    public partial class Teacher
    {
        public int Id { get; set; }
        public int PersonId { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<Course> CoursesAsLecturer { get; set; }
        public virtual ICollection<Course> CoursesAsPracticeTeacher { get; set; }
    }
}
