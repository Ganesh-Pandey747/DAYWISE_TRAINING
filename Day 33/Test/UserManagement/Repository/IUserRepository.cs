using UserManagement.Model;
namespace UserManagement.Repository
{
    public interface IUserRepository
    {
         void CreateUser(User user);

         User validateUser(string usr, string pass);
    }
}