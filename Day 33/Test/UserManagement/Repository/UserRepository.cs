using System.Linq;
using UserManagement.Context;
using UserManagement.Model;

namespace UserManagement.Repository
{
    public class UserRepository : IUserRepository
    { 
        UserDbContext context;
         
        public UserRepository(UserDbContext _context)
        {
            context=_context;
            
        }
        void IUserRepository.CreateUser(User user)
        {
            context.Add(user);
            context.SaveChanges();
            
        }

        User IUserRepository.validateUser(string usr, string pass)
        {
            var record = context.users.SingleOrDefault(ctr=>ctr.UserName==usr && ctr.UserPassword==pass);
            if(record!=null)
            {
                return record;
            }
            return null;
            
        }
    }
}