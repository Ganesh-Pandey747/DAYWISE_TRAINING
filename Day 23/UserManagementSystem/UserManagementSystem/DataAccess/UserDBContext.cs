using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.DataAccess
{
    public class UserDBContext:DbContext
    {
        public UserDBContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMapper(modelBuilder.Entity<User>());
        }
        public DbSet<User> users{get;set;}   //Wrong Way
    }
}