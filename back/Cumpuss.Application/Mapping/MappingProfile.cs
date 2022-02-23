using AutoMapper;

namespace Cumpuss.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Infrastructure.Models.User, Application.Models.User>();

            CreateMap<Infrastructure.Models.Grade, Application.Models.Grade>();
            CreateMap<Infrastructure.Models.Grade, Domain.Models.IGrade>().As<Application.Models.Grade>();

            CreateMap<Infrastructure.Models.Class, Application.Models.Class>();
            CreateMap<Infrastructure.Models.Class, Domain.Models.IClass>().As<Application.Models.Class>();

            CreateMap<Infrastructure.Models.Course, Application.Models.Course>();
            CreateMap<Infrastructure.Models.Course, Domain.Models.ICourse>().As<Application.Models.Course>();
        }
    }
}
