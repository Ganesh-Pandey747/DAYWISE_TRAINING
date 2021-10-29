using Microsoft.EntityFrameworkCore;
using UserManagemment2.Domain;
namespace UserManagemment2.Repository
{
    public class ApplicationContext : DbContext
    {
        
        
        public ApplicationContext(DbContextOptions options):base (options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Linking Between User(Model) and UserMap(Mapper)
             new UserMap(modelBuilder.Entity<User>());
             //Linking Between UserProfile(Model) and UserMap(Mapper)
              new UserProfileMap(modelBuilder.Entity<UserProfile>());
            
        }
    }
}