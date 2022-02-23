using Cumpuss.Application.Holders;
using Cumpuss.Application.Request;
using Cumpuss.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cumpuss.Application.Managers
{
    public class CoursesManager : BaseManager
    {
        public CoursesManager(RequestContext requestContext) : base(requestContext) { }

        public IEnumerable<ICourse> GetCoursesWithGrades(int studentId, int year, bool firstSemester)
        {
            return MapperHolder.Instance.Map<IEnumerable<ICourse>>(
                _RequestContext.Repository.GetCoursesWithGrades(studentId, year, firstSemester));
        }
    }
}
