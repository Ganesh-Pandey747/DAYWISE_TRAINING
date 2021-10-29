using UsermanagementService.Data;
using System.Collections.Generic;
using UsermanagementService.Models;
namespace UsermanagementService.Service
{
    public interface IUserRepository
    {
        int AddUser(User user);
        int UpdateUser(int Id,User user);
        int DeleteUser(int Id);
        User SearchUser(int Id);
        IEnumerable<User> GetUsers();

         
    }
}