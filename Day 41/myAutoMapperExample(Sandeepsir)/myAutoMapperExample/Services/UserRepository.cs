using System.Collections.Generic;
using myAutoMapperExample.myPOCO;
using myAutoMapperExample.Repository;
using System;
namespace myAutoMapperExample.Services
{
    public class UserRepository:IUserRepository
    {
        IRepository<User> userRepository;
        IRepository<UserProfile> userprofileRepository;
        public UserRepository(IRepository<User> _user, IRepository<UserProfile> _userprofile)
        {
            userRepository = _user;
            userprofileRepository = _userprofile;
        }
        void IUserRepository.DeleteUser(long id)
        {
            //first we need to delete from dependent table
            UserProfile userProfile = userprofileRepository.Get(id);
            userprofileRepository.Remove(userProfile);

            //then we need to delete from master table
            User user = userRepository.Get(id);
            userRepository.Remove(user);
            userRepository.SaveChanges();
        }

        User IUserRepository.GetUser(long id)
        {
            return userRepository.Get(id);
        }

        IEnumerable<User> IUserRepository.GetUsers()
        {
            throw new System.NotImplementedException();
        }

        void IUserRepository.InsertUser(User user)  //we have both User and UserProfile at this point
        {
            userRepository.Insert(user);
        }

        void IUserRepository.UpdateUser(User user)
        {
            userRepository.Update(user);
        }
    }
}