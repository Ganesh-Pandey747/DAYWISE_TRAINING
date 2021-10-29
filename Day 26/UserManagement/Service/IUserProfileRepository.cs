using UserManagement.Domain;
namespace UserManagement.Service
{
    public interface IUserProfileRepository
    {
       UserProfile getUserProfile(long id);
        
    }
}