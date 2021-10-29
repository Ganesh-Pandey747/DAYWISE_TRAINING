using System;
using System.Collections.Generic;

#nullable disable

namespace TokenAuthentication.Entites
{
    public partial class Tbluser
    {
        public int Userid { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public byte[] Salt { get; set; }
    }
}
