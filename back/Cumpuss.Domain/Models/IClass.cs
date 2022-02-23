using Cumpuss.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Cumpuss.Domain.Models
{
    public interface IClass : IEntity
    {
        DateTime Date { get; }
        ClassType ClassType { get; }
        string? CustomCaption { get; }
        public IEnumerable<IGrade> Grades { get; set; }
    }
}
