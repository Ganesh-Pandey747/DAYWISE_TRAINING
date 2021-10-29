using System.ComponentModel.DataAnnotations;
namespace UserManagement.Model
{
    public class User
    {
       [Key]
        public string UserName{get;set;}
        public string UserPassword{get;set;}
        

    }
}