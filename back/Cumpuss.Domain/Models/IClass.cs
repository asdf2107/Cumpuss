using Cumpuss.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Cumpuss.Domain.Models
{
    public interface IClass
    {
        int CourseId { get; }
        DateTime Date { get; }
        ClassType ClassType { get; }
        string CustomCaption { get; }
    }
}
