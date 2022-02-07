using System.Collections.Generic;

namespace Cumpuss.Domain.Models
{
    public interface IPerson
    {
        string Name { get; }
        string Sirname { get; }
        string Patronymic { get; }
        string Email { get; }
    }
}
