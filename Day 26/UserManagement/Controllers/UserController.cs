using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserManagement.Service;
namespace UserManagement.Controllers
{
    [ApiController]
    [Route("taazaa/[Controller]")]
    public class UserController:ControllerBase
    {
        IUserProfileRepository userProfileRepository;
        IUserRepository userRepository;

        public UserController(UserProfileRepository _userProfileRepository, IUserRepository _userRepository)
        {
            userProfileRepository=_userProfileRepository;
            userRepository=_userRepository;
        }
        public IActionResult createAccount();
       
    }
}