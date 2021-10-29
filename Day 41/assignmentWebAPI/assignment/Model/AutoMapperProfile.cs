using Assignment.Model;
using AutoMapper;
namespace Assignment.Model
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDTO, User>();
            
        }
    }
}