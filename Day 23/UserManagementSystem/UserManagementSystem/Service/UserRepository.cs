using UserManagementSystem.DataAccess;
namespace UserManagementSystem.Service
{
    public class UserRepository
    {
        UserDBContext userDBContext;
        public UserRepository(UserDBContext _userDBContext)
        {
            userDBContext=_userDBContext;
        }
    }
}