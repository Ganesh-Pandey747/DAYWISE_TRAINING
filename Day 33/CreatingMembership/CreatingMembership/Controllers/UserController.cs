using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CreatingMembership.Data;
using CreatingMembership.BLL;
using CreatingMembership.Models;

namespace CreatingMembership.Controllers
{
      [ApiController]
    [Route("Taazaa/[controller]")]
    public class UserController:ControllerBase
    {
        IUserRepository repository;
        public UserController(IUserRepository _repository)
        {
            repository=_repository;
        }
        [HttpPost("AddMembership")]
        public IActionResult CreatingMembership(User user)
        {
            var temp=repository.AddUser(user);
            return Ok(temp);
        }
        [HttpGet]
        public IActionResult LoginUser(string nm , string Password)
        {
            var temp=repository.Login(nm,Password);
            return Ok(temp);
        }
    }
}