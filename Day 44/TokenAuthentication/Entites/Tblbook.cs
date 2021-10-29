using System;
using System.Collections.Generic;

#nullable disable

namespace TokenAuthentication.Entites
{
    public partial class Tblbook
    {
        public int Bookid { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public string Publisher { get; set; }
        public decimal Price { get; set; }
    }
}
