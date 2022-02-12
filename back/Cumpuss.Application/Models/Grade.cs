using Cumpuss.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cumpuss.Application.Models
{
    internal class Grade : IGrade
    {
        public double Value { get; set; }
        public int StudentId { get; set; }
    }
}
