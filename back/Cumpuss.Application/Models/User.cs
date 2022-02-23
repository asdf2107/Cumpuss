using Cumpuss.Domain.Enums;
using Cumpuss.Domain.Models;

namespace Cumpuss.Application.Models
{
    public class User : IUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public UserType UserType { get; set; }   
    }
}
