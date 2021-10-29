using System.Collections;
using System;
using System.Collections.Generic;
using ListAssignment.Model;

namespace ListAssignment.Collection

{
    public class Collections
    {
        public  List<Contact> ContactDetails()
       {
           List<Contact> Con=new List<Contact>();
           Con.Add(new Contact{
               ContactId=123,
               ContactName="Ganesh",
               ContactPhoneNo=999
               
           });
            Con.Add(new Contact{
               ContactId=124,
               ContactName="Shubham",
               ContactPhoneNo=747
           });
           return Con;
    }
    }
}