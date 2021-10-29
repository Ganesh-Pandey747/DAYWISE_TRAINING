using System.Collections.Generic;
using MovieManagement.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Data;


namespace MovieManagement.Service
{
    public class MovieRepository:IMovieRepository
    {
        MovieDbContext _context;
        public MovieRepository(MovieDbContext context)
        {
           _context=context;
        }
        int IMovieRepository.AddMovie(Movie movie)
        {
            _context.Add(movie);
            int temp=_context.SaveChanges();
            return temp;
            
        }

        int IMovieRepository.DeleteMovie(int Id)
        {
            int res=0;
            var movie=_context.movies.FirstOrDefault(z=>z.MovieId==Id);
            if(movie!=null)
            {
                _context.movies.Remove(movie);
                res=_context.SaveChanges();
            }
            return res;
           
        }

        IEnumerable<Movie> IMovieRepository.GetMovies()
        {
            var movie=_context.movies.ToList();
            return movie;
           
        }

        Movie IMovieRepository.SearchMovie(int Id)
        {
            var movie1=_context.movies.FirstOrDefault(z=>z.MovieId==Id);
            return movie1;
            
          
        }

        int IMovieRepository.UpdateMovie(int MovieId, Movie movie)
        {
            int res=0;
          var movie1=_context.movies.Find(MovieId);
          if(movie1!=null)
          {
              movie1.MovieYr=movie.MovieYr;
              movie1.Moviename=movie.Moviename;
              res=_context.SaveChanges();
          }   
          return res;
           
        }
    }
}