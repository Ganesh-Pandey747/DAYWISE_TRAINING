using Assignment.Model;

namespace Assignment.Repository
{
    public interface IUserRepository
    {
         void InsertUSer(User user);
         User GetSingleRecord(string Name,string Password);
    }
}