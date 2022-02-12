using Cumpuss.Domain.Models;
using Cumpuss.Infrastructure;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Security.Claims;

namespace Cumpuss.Application
{
    public class RequestContext
    {
        internal IUser User { get; private set; }
        internal CumpussDBContext DBContext { get; private set; }

        public RequestContext(HttpContext httpContext)
        {
            DBContext = new CumpussDBContext();
            //User = DBContext.Users.First(u => u.Id == int.Parse(httpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value));
        }
    }
}
