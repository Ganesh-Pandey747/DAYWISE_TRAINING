using Microsoft.EntityFrameworkCore;
using UserManagement.Model;
using UserManagement.Context;
using UserManagement.Repository;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace UserManagement.Controllers
{
    [ApiController]
    [Route("Taazaa/[Controller]")]
    public class UserController:ControllerBase
    {
        IUserRepository iuser;


        public UserController(IUserRepository _iuser)
        {
            iuser=_iuser;           
        }
        [HttpPost]
        [Route("Create Account")]

        public IActionResult CreateAccount(User user)
        {
            iuser.CreateUser(user);
            return Ok("Account Created");

        } 

        [HttpGet]
        [Route("Validate Account")]

        public IActionResult ValidateAccount(string usr, string pass)
        {
           var record = iuser.validateUser(usr, pass);
           if(record!=null)
           {
               return Ok("Logged in Successfully");
           }
           return Ok("Please enter valid username and password");
        }
    }
}