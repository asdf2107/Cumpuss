using Cumpuss.Domain.Enums;

namespace Cumpuss.Domain.Models
{
    public interface IUser : IEntity
    {
        string Username { get; }
        UserType UserType { get; }
    }
}
