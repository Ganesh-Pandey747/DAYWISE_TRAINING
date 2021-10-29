using UserManagemment2.Domain;
using UserManagemment2.Repository;
namespace UserManagemment2.Service
{
    public class UserProfileRepository : IUserProfileRepository
    {
        IRepository<UserProfile> userprofileRepository;
        public UserProfileRepository( IRepository<UserProfile> _userprofile)
        {
            userprofileRepository=_userprofile;
        }
        UserProfile IUserProfileRepository.GetUserProfile(int id)
        {
            return userprofileRepository.Get(id);
            
        }
    }
}