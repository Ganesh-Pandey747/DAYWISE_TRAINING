using Assignment.Model;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Context
{
    public class UserDbContext:DbContext
    {
        public DbSet<User> users{get;set;}
        public UserDbContext(DbContextOptions dbContextOptions):base (dbContextOptions)
        {
            
        }
    }
}