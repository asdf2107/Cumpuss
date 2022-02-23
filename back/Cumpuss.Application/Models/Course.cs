using Cumpuss.Domain.Models;
using System.Collections.Generic;

namespace Cumpuss.Application.Models
{
    public class Course : ICourse
    {
        public int Year { get; set; }
        public bool FirstSemester { get; set; }
        public ISubject Subject { get; set; }
        public ITeacher Lecturer { get; set; }
        public ITeacher PracticeTeacher { get; set; }
        public IEnumerable<IClass> Classes { get; set; }
    }
}
