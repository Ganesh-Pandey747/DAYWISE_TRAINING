using Assignment.Model;
using Assignment.Repository;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("Taazaa/[Controller]")]
    public class UserController : ControllerBase
    {
        IUserRepository userRepository;
        IMapper imapper;

        public UserController(IUserRepository _userRepository, IMapper _imapper)
        {
            userRepository = _userRepository;
            imapper = _imapper;
        }
        [HttpPost("create")]
        public IActionResult Create(UserDTO userDTO)
        {
            if (userDTO == null)
            {
                return BadRequest("Enter Valid Data");
            }
            var usermap = imapper.Map<User>(userDTO);
            userRepository.InsertUSer(usermap);
            return Ok(userDTO.Name);
        }
        [HttpPost("login")]
        public IActionResult Check(UserDTO userDTO)
        {
            if (userDTO.Password == null || userDTO.Name == null)
            {
                return BadRequest("Enter Valid Data");
            }
            var r = userRepository.GetSingleRecord(userDTO.Name, userDTO.Password);
            if (r == null)
            {
                return BadRequest("False");
            }
            return Ok("True");
        }
    }
}