using FluentValidation;
namespace MovieManagement.Models
{
    public class MovieValidator:AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(t=>t.Moviename).NotNull();
            RuleFor(t=>t.MovieYr).InclusiveBetween(2000, 2021);

        }
        
    }
}