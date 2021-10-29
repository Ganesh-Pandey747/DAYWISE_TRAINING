using AutoMapper;

namespace Assignment.Model
{
    public class Automapper:Profile
    {
        public Automapper()
        {
            CreateMap<UserDTO,User>();
        }
    }
}