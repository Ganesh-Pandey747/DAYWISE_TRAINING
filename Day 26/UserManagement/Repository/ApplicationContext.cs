using UserManagement.Domain;
using Microsoft.EntityFrameworkCore;
namespace UserManagement.Repository
{
    public class ApplicationContext:DbContext
    {
        

        public ApplicationContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //here we are linking building between user and usermap and for context we use onconfigure

        }
        
    }
}