using AutoMapper;
using TokenAuthentication.DTOs;
using TokenAuthentication.Entites;

namespace TokenAuthentication.Helpers
{
    public class AutoMapperProfile: Profile
    {
       public AutoMapperProfile()
        {
            //CreateMap<TblBook, BookListDto>();
            CreateMap<LoginDto, Tbluser>();
            CreateMap<RegisterDto, Tbluser>()
           .ForMember(dest => dest.Password, opt => opt.MapFrom(src => System.Text.Encoding.Unicode.GetBytes( src.Password)));

        }
    }
}