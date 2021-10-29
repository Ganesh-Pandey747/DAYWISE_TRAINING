using Microsoft.EntityFrameworkCore;
using UserManagement.Model;

namespace UserManagement.Context
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<User> users{get;set;}
        
    }
}