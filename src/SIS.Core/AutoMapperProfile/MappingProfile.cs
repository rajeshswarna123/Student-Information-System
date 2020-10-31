using AutoMapper;
using SIS.Core.ClientContext;
using SIS.Entities;

namespace SIS.Core.AutoMapperProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserProfile, User>().ReverseMap();
        }
    }
}
