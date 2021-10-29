using System;
namespace myAutoMapperExample.myPOCO
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime modifyDate { get; set; }
        public string IPAddress { get; set; }
    }
}