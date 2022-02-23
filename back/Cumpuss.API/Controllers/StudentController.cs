using Cumpuss.API.Filters;
using Cumpuss.Application.Managers;
using Cumpuss.Application.Request;
using Cumpuss.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Cumpuss.Presentation.Controllers
{
    [ApiController]
    [Authorize]
    [AddUsernameFromToken]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet("grades")]
        public IEnumerable<ICourse> GetCoursesWithGrades(int? year, bool? firstSemester)
        {
            var requestContext = new RequestContext(HttpContext);
            return new CoursesManager(requestContext).GetCoursesWithGrades(requestContext.User.Id, year ?? DateTime.Today.Year, firstSemester ?? true);
        }
    }
}