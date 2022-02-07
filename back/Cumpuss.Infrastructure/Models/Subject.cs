using System.Collections.Generic;

namespace Cumpuss.Infrastructure.Models
{
    public class Subject
    {
        public Subject()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
