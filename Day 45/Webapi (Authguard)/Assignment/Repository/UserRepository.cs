using Assignment.Context;
using Assignment.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Repository
{
    public class UserRepository : IUserRepository
    {
        UserDbContext userDbContext;
        public UserRepository(UserDbContext _userDbContext)
        {
            userDbContext=_userDbContext;
        }
        void IUserRepository.InsertUSer(User user)
        {
            userDbContext.users.Add(user);
            userDbContext.SaveChanges();
        }
        User IUserRepository.GetSingleRecord(string email, string Password)
        {
            var result =userDbContext.users.FirstOrDefault(ctr=>ctr.Email==email && ctr.Password==Password);
            if(result==null)
            {
                return null;
            }
            return result;
        }
    }
}