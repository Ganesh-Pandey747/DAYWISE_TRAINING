using System.Collections.Generic;
using System;
using myAutoMapperExample.myPOCO;
namespace myAutoMapperExample.Services
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