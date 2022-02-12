using AutoMapper;
using Cumpuss.Application;
using Cumpuss.Application.Student;
using Cumpuss.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Cumpuss.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IMapper _Mapper;

        public StudentController(IMapper mapper)
        {
            _Mapper = mapper;
        }

        [HttpGet("getgrades")]
        public IEnumerable<IGrade> GetGrades(int studentId, int classId)
        {
            return new GradesManager(new RequestContext(HttpContext), _Mapper).GetGrades(studentId, classId);
        }
    }
}