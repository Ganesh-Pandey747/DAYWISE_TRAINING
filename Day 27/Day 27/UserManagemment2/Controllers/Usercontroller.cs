using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserManagemment2.Service;
using UserManagemment2.Domain;

namespace UserManagemment2.Controllers
{
    [ApiController]
    [Route("Taazaa/[controller]")]
    public class Usercontroller : ControllerBase
    {
        IUserRepository userRepository;
        IUserProfileRepository userProfileRepository;
        public Usercontroller(IUserRepository _userRepository ,  IUserProfileRepository _userProfileRepository)
        {
             userRepository= _userRepository;
             userProfileRepository= _userProfileRepository;
        }
        [HttpPost]
        [Route("AddUser")]
        public IActionResult CreateAccount(UserDTO model)
        {
            User userEntity = new User
            {
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                AddedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                userProfile = new UserProfile
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    AddedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                }
            };
            return Ok(userRepository.InsertUser(userEntity));
        } 
}
}
