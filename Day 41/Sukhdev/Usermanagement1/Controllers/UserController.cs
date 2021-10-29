using System;
using Microsoft.AspNetCore.Mvc;
using Usermanagement1.Services;
using Usermanagement1.Domain;
using AutoMapper;
namespace Usermanagement1.Controllers
{
    [ApiController]
    [Route("taazaa/[controller]")]
    public class UserController : ControllerBase
    {
        IUserRepository userRepository;
        IMapper imapper1;
        IUserprofileRepository userprofileRepository;
        public UserController(IUserprofileRepository _userprofileRepository, IUserRepository _userRepository,IMapper imapper)
        {
            userRepository = _userRepository;
            userprofileRepository = _userprofileRepository;
            imapper1=imapper;
        }
        [HttpPost]
        [Route("User/Insert")]
        public IActionResult CreateAccount(UserDTO model)
        {
           var Data=imapper1.Map<User>(model);
         /*    User userEntity = new User
            {
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                AddedDate = DateTime.UtcNow,
                modifyDate = DateTime.UtcNow,
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                userProfile = new UserProfile
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    AddedDate = DateTime.UtcNow,
                    modifyDate = DateTime.UtcNow,
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                }
            }; */
            userRepository.InsertUser(Data);    //here we have two classes data in userEntity that is(user Class And UserProfile class)
            return Ok("Record Added!!");
        }


        [HttpPut("Edit/{id}")]
        public IActionResult UpdateAccount(UserDTO model)
        {
            User userEntity = userRepository.GetUser(model.Id);
            userEntity.Email = model.Email;
            userEntity.modifyDate = DateTime.UtcNow;
            userEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            UserProfile userProfileEntity = userprofileRepository.GetUserProfile(Convert.ToInt16(model.Id));
            userProfileEntity.FirstName = model.FirstName;
            userProfileEntity.LastName = model.LastName;
            userProfileEntity.Address = model.Address;
            userProfileEntity.modifyDate = DateTime.UtcNow;
            userProfileEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();

            userEntity.userProfile = userProfileEntity;
            userRepository.UpdateUser(userEntity);
            return Ok(model);
        }
        [HttpDelete("Delete")]
        public IActionResult DeleteUser(int id)
        {
            UserProfile userProfile = userprofileRepository.GetUserProfile(id);
            userRepository.DeleteUser(id);
            return Ok("Deleted!!");
        }
        [HttpGet("SearchUser")]
        public UserProfile SearchUsers(int id)
        {
            UserProfile userProfile = userprofileRepository.GetUserProfile(id);
            return userProfile;
        }
    }
}