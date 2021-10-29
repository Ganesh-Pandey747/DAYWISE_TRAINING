using UserManagement.Domain;
using System.Collections.Generic;
namespace UserManagement.Service
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUser(long id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(long id);   
    }
}