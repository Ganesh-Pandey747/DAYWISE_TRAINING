using System;
namespace Usermanagement1.Domain
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime modifyDate { get; set; }
        public string IPAddress { get; set; }

    }
}