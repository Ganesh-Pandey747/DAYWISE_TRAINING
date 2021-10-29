using System.Collections.Generic;
using Usermanagement1.Domain;
namespace Usermanagement1.Services
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