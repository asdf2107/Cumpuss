using System;
using System.Collections.Generic;

namespace Cumpuss.Infrastructure.Models
{
    public partial class Class
    {
        public Class()
        {
            Grades = new HashSet<Grade>();
        }

        public int Id { get; set; }
        public int CourseId { get; set; }
        public DateTime Date { get; set; }
        public short ClassType { get; set; }
        public string CustomCaption { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}
