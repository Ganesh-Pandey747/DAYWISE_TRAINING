using FluentValidation;
namespace UsermanagementService.Models
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(t=>t.username).NotNull();
            RuleFor(t=>t.Age).InclusiveBetween(15, 25);

        }
        
    }
}