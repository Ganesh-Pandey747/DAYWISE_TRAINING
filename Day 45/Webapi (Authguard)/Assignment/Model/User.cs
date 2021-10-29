using System.ComponentModel.DataAnnotations;
namespace Assignment.Model
{
    public class User
    {
        [Key]
        public string FullName{get;set;}
        public string Email{get;set;}
        public string Password{get;set;}
        
    }
}