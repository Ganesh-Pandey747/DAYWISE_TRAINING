using userManagement.Domain;
using Microsoft.EntityFrameworkCore;
namespace userManagement.Repository
{
    public class AppilcationContext:DbContext
    {
        
        public AppilcationContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // here we are linking building between user and usermap and for context we use onconfigure
            new UserMap(modelBuilder.Entity<User>());
            new UserProfileMap(modelBuilder.Entity<UserProfile>());
        }
    }
}