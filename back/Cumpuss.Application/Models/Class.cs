using Cumpuss.Domain.Enums;
using Cumpuss.Domain.Models;
using System;
using System.Collections.Generic;

namespace Cumpuss.Application.Models
{
    public class Class : IClass
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ClassType ClassType { get; set; }
        public string? CustomCaption { get; set; }
        public IEnumerable<IGrade> Grades { get; set; }
    }
}
