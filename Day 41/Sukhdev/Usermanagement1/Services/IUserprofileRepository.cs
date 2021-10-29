using Usermanagement1.Domain;
namespace Usermanagement1.Services
{
    public interface IUserprofileRepository
    {
        UserProfile GetUserProfile(int id);
    }
}