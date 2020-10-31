using AutoMapper;
using SIS.Core.ClientContext;
using SIS.Entities;

namespace SIS.Core.AutoMapperProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.UserProfile, User>().ReverseMap();

            CreateMap<Student, Models.Student>().ReverseMap();

            CreateMap<Marks, Models.Marks>().ReverseMap();
        }
    }
}
