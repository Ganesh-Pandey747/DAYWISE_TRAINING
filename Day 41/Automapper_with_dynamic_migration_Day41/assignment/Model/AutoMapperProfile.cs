using Assignment.Model;
using AutoMapper;
namespace assignment.Model
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDTO, User>();
            
        }
    }
}