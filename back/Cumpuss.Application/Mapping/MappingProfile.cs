using AutoMapper;

namespace Cumpuss.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Infrastructure.Models.Grade, Application.Models.Grade>();
            CreateMap<Infrastructure.Models.Grade, Domain.Models.IGrade>().As<Application.Models.Grade>();
        }
    }
}
