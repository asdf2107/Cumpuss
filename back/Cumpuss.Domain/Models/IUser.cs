using Cumpuss.Domain.Enums;

namespace Cumpuss.Domain.Models
{
    public interface IUser
    {
        string Login { get; }
        UserType UserType { get; }
        IPerson Face { get; }
    }
}
