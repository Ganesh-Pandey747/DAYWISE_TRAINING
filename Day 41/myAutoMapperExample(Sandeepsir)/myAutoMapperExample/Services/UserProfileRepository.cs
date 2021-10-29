using System;
using myAutoMapperExample.myPOCO;
using myAutoMapperExample.Repository;
namespace myAutoMapperExample.Services
{
    public class UserProfileRepository:IUserprofileRepository
    {
        IRepository<UserProfile> userProfileRepository;
        public UserProfileRepository(IRepository<UserProfile> _userProfile)
        {
            userProfileRepository = _userProfile;
        }

        UserProfile IUserprofileRepository.GetUserProfile(int id)
        {
            return userProfileRepository.Get(id);
        }

    }
}