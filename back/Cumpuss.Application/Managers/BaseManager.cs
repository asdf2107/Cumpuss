using AutoMapper;
using Cumpuss.Application.Request;

namespace Cumpuss.Application.Managers
{
    public abstract class BaseManager
    {
        protected readonly RequestContext _RequestContext;

        public BaseManager(RequestContext requestContext)
        {
            _RequestContext = requestContext;
        }
    }
}
