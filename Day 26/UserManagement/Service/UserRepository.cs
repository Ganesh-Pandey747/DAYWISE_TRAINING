using System.Collections.Generic;
using UserManagement.Domain;
using System;
using UserManagement.Repository;

namespace UserManagement.Service
{
    public class UserRepository : IUserRepository
    {
        IRepository<User> userRepository;
        IRepository<UserProfile> userProfileRepository;
        public UserRepository(IRepository<User> _userRepository, IRepository<UserProfile> _userProfileRepository)
        {
            userRepository = _userRepository;
            userProfileRepository = _userProfileRepository;
        }
        void IUserRepository.DeleteUser(long id)
        {

            
            // First we need to delete from the dependent table
           UserProfile userProfile= userProfileRepository.Get(id);
           userProfileRepository.Remove(userProfile);

            // then we need to delete from the master table
           User user= userRepository.Get(id);
           userRepository.Remove(user);
           userRepository.SaveChanges();
        }

        User IUserRepository.GetUser(long id)
        {
            return userRepository.Get(id);           
        }

        IEnumerable<User> IUserRepository.GetUsers()
        {
            return userRepository.GetAll();
            
        }

        void IUserRepository.InsertUser(User user)
        {
            userRepository.Insert(user);
           
        }

        void IUserRepository.UpdateUser(User user)
        {
            userRepository.Update(user);
        }
    }
}