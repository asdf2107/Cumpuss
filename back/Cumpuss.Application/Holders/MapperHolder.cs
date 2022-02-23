using AutoMapper;

#nullable disable

namespace Cumpuss.Application.Holders
{
    public class MapperHolder
    {
        private static IMapper _Mapper;

        public static void Setup(IMapper mapper)
        {
            _Mapper = mapper;
        }

        public static IMapper Instance { get { return _Mapper; } }
    }
}
