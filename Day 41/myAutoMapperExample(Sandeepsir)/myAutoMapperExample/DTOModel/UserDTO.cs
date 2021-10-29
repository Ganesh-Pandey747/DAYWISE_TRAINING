using System;
using myAutoMapperExample.myPOCO;
namespace myAutoMapperExample.DTOModel
{
    public class UserDTO
    {
        public Int64 Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime modifyDate { get; set; }
        public string IPAddress { get; set; }

    }
}