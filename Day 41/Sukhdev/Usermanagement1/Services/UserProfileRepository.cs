using System;
using Usermanagement1.Repository;
using Usermanagement1.Domain;
namespace Usermanagement1.Services
{
    public class UserProfileRepository : IUserprofileRepository
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
