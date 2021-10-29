using Assignment.Model;
using Assignment.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("Taazaa/[Controller]")]
    public class UserController:ControllerBase
    {
        IUserRepository userRepository;
        IMapper imapper;
        
        public UserController(IUserRepository _userRepository,IMapper _imapper)
        {
            userRepository=_userRepository;
            imapper=_imapper;
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(UserDTO userdto)
        {
            if(userdto==null)
            {
                return BadRequest("Enter Valid Data");
            }
           /*  User obj=new User();  //Pervious way of mapping
            obj.Id=user.Id;
            obj.Name=user.Name;
            obj.Password=user.Password;
            obj.Age=user.Age; */
            
            var mapp=imapper.Map<User>(userdto);
            userRepository.InsertUSer(mapp);
            return Ok(userdto.FullName);
        }
        [HttpPost]
        [Route("check")]
        public IActionResult Check(UserDTO userDTO)
        {
            if(userDTO.Password==null||userDTO.Email==null)
            {
                return BadRequest("Enter Valid Data");
            }
            var r=userRepository.GetSingleRecord(userDTO.Email,userDTO.Password);
            if (r==null)
            {
                return BadRequest("False");
            }
            return Ok(r);
        }
    }
}