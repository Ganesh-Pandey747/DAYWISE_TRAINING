using Microsoft.EntityFrameworkCore;
using UsermanagementService.Models;
namespace UsermanagementService.Data
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> users{get;set;}
        public UserDbContext(DbContextOptions options):base(options)
        {
        }
        protected  override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Linking bitween user and usermap
            new UserMap(modelBuilder.Entity<User>());
        }
        
    }
}