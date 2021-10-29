using System.Collections.Generic;
using UsermanagementService.Data;
using UsermanagementService.Models;
using System.Linq;

namespace UsermanagementService.Service
{
    public class UserRepository:IUserRepository
    {   
        UserDbContext _context;
        public UserRepository(UserDbContext context)
        {
           _context=context;
        }

        int IUserRepository.AddUser(User user)
        {
            _context.Add(user);
            int temp=_context.SaveChanges();
            return temp;
        }

        int IUserRepository.DeleteUser(int Id)
        {
            int res=0;
            var user=_context.users.FirstOrDefault(z=>z.Id==Id);
            if(user!=null)
            {
                _context.users.Remove(user);
                res=_context.SaveChanges();
            }
            return res;
            
        }

        IEnumerable<User> IUserRepository.GetUsers()
        {
            var user=_context.users.ToList();
            return user;
            
        }

        User IUserRepository.SearchUser(int Id)
        {
            var user=_context.users.FirstOrDefault(z=>z.Id==Id);
            return user;
            
        }

        int IUserRepository.UpdateUser(int id, User user)
        {
          int res=0;
          var users=_context.users.Find(id);
          if(users!=null)
          {
              users.Age=user.Age;
              users.username=user.username;
              res=_context.SaveChanges();
          }   
          return res;       
        }
    }
}