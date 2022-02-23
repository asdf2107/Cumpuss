using Cumpuss.Application.Holders;
using Cumpuss.Application.Models;
using Cumpuss.Infrastructure;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace Cumpuss.Application.Request
{
    public class RequestContext
    {
        public User User { get; private set; }
        internal Repository Repository { get; private set; }

        public RequestContext(HttpContext httpContext)
        {
            Repository = new Repository(new CumpussDBContext());
            string? userName = httpContext.Items[CustomClaimTypes.Name].ToString();
            User = MapperHolder.Instance.Map<User>(Repository.GetUserByName(userName));
        }
    }
}
