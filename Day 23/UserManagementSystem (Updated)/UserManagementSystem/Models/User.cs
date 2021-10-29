using System;
using System.Collections.Generic;

#nullable disable

namespace UserManagementSystem.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int UserPhoneNo { get; set; }
        public int UserAge { get; set; }
    }
}
