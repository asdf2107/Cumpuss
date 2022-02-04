using System;
using System.Collections.Generic;

namespace Cumpuss.Infrastructure.Models
{
    public partial class Group
    {
        public Group()
        {
            GroupsToCourses = new HashSet<GroupsToCourse>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GroupsToCourse> GroupsToCourses { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
