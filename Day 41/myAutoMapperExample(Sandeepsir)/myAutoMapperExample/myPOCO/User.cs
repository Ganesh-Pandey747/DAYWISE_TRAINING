using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System;
namespace myAutoMapperExample.myPOCO
{
    public class User:BaseEntity
    {
       
       [Key]  
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserProfile userProfile { get; set; } //navigation    //navigation or referential integrity
    }
}