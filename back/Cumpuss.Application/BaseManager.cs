using AutoMapper;

namespace Cumpuss.Application
{
    public class BaseManager
    {
        protected readonly RequestContext _RequestContext;
        protected readonly IMapper _Mapper;

        public BaseManager(RequestContext requestContext, IMapper mapper)
        {
            _RequestContext = requestContext;
            _Mapper = mapper;
        }
    }
}
