using Microsoft.EntityFrameworkCore;
using MovieManagement.Models;

namespace MovieManagement.Data
{
    public class MovieDbContext:DbContext
    {
        public DbSet<Movie> movies{get;set;}
        public MovieDbContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // linking between movie and movie map
            new MovieMap(modelBuilder.Entity<Movie>());
        }
        
    }
}