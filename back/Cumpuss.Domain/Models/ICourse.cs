using System.Collections.Generic;

namespace Cumpuss.Domain.Models
{
    public interface ICourse
    {
        int Year { get; }
        bool FirstSemester { get; }
        ISubject Subject { get; }
        ITeacher Lecturer { get; }
        ITeacher PracticeTeacher { get; }
        IEnumerable<IClass> Classes { get; }
    }
}
