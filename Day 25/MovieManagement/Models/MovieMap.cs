using Microsoft.EntityFrameworkCore.Metadata.Builders; //fluentApi

namespace MovieManagement.Models
{
    public class MovieMap
    {
        public MovieMap(EntityTypeBuilder<Movie> movies)
        {
            movies.HasKey(t=>t.MovieId);
            movies.Property(t=>t.Moviename).HasMaxLength(50);
            movies.Property(t=>t.Moviename).IsRequired();
            movies.Property(t=>t.MovieYr).HasMaxLength(4);
            movies.Property(t=>t.MovieYr).IsRequired();

        }
      
    }   
}