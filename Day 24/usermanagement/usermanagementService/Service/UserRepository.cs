using System.Collections.Generic;
using usermanagementService.Data;
using usermanagementService.Models;
using System.Linq;

namespace usermanagementService.Service
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

        int IUserRepository.DeleteUser(int id)
        {
            int res=0;
            var user=_context.users.FirstOrDefault(t=>t.Id==id);
            if(user!=null)
            {
                _context.users.Remove(user);
                res=_context.SaveChanges();
            } 
            return res;
           
        }

        IEnumerable<User> IUserRepository.GetUsers()
        {
            //show all records
           var user= _context.users.ToList();
           return user;
        }

        User IUserRepository.SearchUser(int id)
        {
           var user=_context.users.FirstOrDefault(t=>t.Id==id);
           return user;
        }

        int IUserRepository.UpdateUser(int id, User user)
        {
           int res=0;
          var users=_context.users.Find(id);
          if(users!=null)
          {
              users.Age=user.Age;
              users.UserName=user.UserName;
              res=_context.SaveChanges();
          }   
          return res;       
        }
    }
}