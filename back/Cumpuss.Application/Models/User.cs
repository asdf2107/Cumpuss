using Cumpuss.Domain.Enums;
using Cumpuss.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cumpuss.Application.Models
{
    public class User : IUser
    {
        public string Login { get; set; }
        public UserType UserType { get; set; }
        public IPerson Face { get; set; }     
    }
}
