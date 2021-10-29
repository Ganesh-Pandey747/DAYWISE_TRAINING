using System;
using ListAssignment.Collection;
namespace ListAssignment
{
    class Program
    {
        static void Main()
        {
            var obj= new Collections();
            var list=obj.ContactDetails();
            int count=list.Count;
            for(int i=0;i<count;i++)
            {
                System.Console.WriteLine(list[i].ContactId+" "+list[i].ContactName+" "+list[i].ContactPhoneNo);
            }

            
        }
    }
}
