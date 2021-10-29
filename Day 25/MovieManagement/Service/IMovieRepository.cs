using MovieManagement.Data;
using System.Collections.Generic;
using MovieManagement.Models;

namespace MovieManagement.Service
{
    public interface IMovieRepository
    {
         int AddMovie(Movie  movie);
        int UpdateMovie(int MovieId,Movie movie);
        int DeleteMovie(int MovieId);
        Movie SearchMovie(int MovieId);
        IEnumerable<Movie> GetMovies();        
    }
}