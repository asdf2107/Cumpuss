using System.Collections.Generic;

namespace Cumpuss.Domain.Models
{
    public interface IStudent
    {
        IPerson Person { get; }
        IGroup Group { get; }
    }
}
