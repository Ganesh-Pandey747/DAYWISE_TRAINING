using AutoMapper;
using myAutoMapperExample.DTOModel;
using myAutoMapperExample.myPOCO;
namespace myAutoMapperExample.myMappingProfile
{
    public class MappingProfiles:Profile
    {
 
            public MappingProfiles()
            {
            CreateMap<User, UserDTO>()
             .ForMember(dest => dest.FirstName, act => act.MapFrom(src => src.userProfile.FirstName))
                    .ForMember(dest => dest.LastName, act => act.MapFrom(src => src.userProfile.LastName))
                    .ForMember(dest => dest.Address, act => act.MapFrom(src => src.userProfile.Address))
                    .ReverseMap();
            }
    }
}