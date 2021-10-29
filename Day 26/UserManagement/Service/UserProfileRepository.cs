using UserManagement.Domain;
using System;
using UserManagement.Repository;

namespace UserManagement.Service
{
    public class UserProfileRepository:IUserProfileRepository
    {
        IRepository<UserProfile> userProfileRepository;
        public UserProfileRepository(IRepository<UserProfile> _userProfileRepository )
        {
            userProfileRepository=_userProfileRepository;
        }

        UserProfile IUserProfileRepository.getUserProfile(long id)
        {
           return userProfileRepository.Get(id);
        }
    }
}