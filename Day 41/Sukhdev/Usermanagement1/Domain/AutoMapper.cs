using AutoMapper;
namespace Usermanagement1.Domain
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
        /*     CreateMap<UserDTO,User>().ForMember((t => new{
                t.UserName,
                t.Email,
                t.Password
            }),(x => x.MapFrom(src => new{
                src.UserName,
                src.Email,
                src.Password
            }))); */

            CreateMap<User,UserDTO>()
            .ForMember(dest => dest.FirstName,src => src.MapFrom(x => x.userProfile.FirstName))
            .ForMember(dest => dest.LastName, src => src.MapFrom(x => x.userProfile.LastName))
            .ForMember(dest => dest.Address,src => src.MapFrom(x => x.userProfile.Address)).ReverseMap();
        }
    }
}





