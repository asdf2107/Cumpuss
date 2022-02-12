using AutoMapper;
using Cumpuss.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cumpuss.Application.Student
{
    public class GradesManager : BaseManager
    {
        public GradesManager(RequestContext requestContext, IMapper mapper) : base(requestContext, mapper) { }

        public IEnumerable<IGrade> GetGrades(int studentId, int classId)
        {
            return _Mapper.Map<IEnumerable<IGrade>>(_RequestContext.DBContext.Grades
                .Where(g => g.StudentId == studentId && g.ClassId == classId)
                .ToArray());
        }
    }
}
