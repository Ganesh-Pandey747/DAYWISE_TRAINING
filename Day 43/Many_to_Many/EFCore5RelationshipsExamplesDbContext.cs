using EFCore5RelationshipsExamples.Models.ManyToMany;
using Microsoft.EntityFrameworkCore;

namespace EFCore5RelationshipsExamples
{
    public class EFCore5RelationshipsExamplesDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;User ID=postgres;Password=1234;Database=MovieDb43;Pooling=true;");
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}