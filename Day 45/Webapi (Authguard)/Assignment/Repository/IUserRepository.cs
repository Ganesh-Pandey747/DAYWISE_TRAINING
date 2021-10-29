using Assignment.Model;

namespace Assignment.Repository
{
    public interface IUserRepository
    {
         void InsertUSer(User user);
         User GetSingleRecord(string UserName,string Password);
    }
}