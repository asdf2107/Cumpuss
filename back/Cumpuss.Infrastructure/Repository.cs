using Cumpuss.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cumpuss.Infrastructure
{
    public class Repository
    {
        private CumpussDBContext _DBContext;

        public Repository(CumpussDBContext dbContext)
        {
            _DBContext = dbContext;
        }

        public User GetUserByName(string userName)
        {
            return _DBContext.Users
                .FirstOrDefault(u => u.Username == userName);
        }

        public List<Course> GetCoursesWithGrades(int studentId, int year, bool firstSemester)
        {
            var result = (from c in _DBContext.Courses
                          where c.Year == year && c.FirstSemester == firstSemester
                          select c)
                          .Include(c => c.Classes)
                          .ToList();

            var grades = (from cl in _DBContext.Classes
                          join gr in _DBContext.Grades on cl.Id equals gr.ClassId
                          where result.Select(c => c.Id).Contains(cl.Id)
                          select gr)
                          .ToList();

            foreach (var course in result)
            {
                foreach (var @class in course.Classes)
                {
                    @class.Grades = grades.Where(g => g.ClassId == @class.Id).ToList();
                }
            }

            //.IncludeFilter(c => c.Classes.Select(
            //    cl => cl.Grades
            //    .Where(g => g.StudentId == studentId)))
            //.ToList();
            return result;
        }
    }
}
