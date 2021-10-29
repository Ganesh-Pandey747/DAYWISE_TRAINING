using System;
using System.Collections.Generic;
using ListAssignment.Model;

namespace ListAssignment
{
    class Program
    {
        static void Main()
        {
            List<Contact1> obj =new List<Contact1>();
            obj.Add(new Contact1{
                contactId=101,
                contactName="Ganesh"

            });
            obj.Add(new Contact1{
                contactId=102,
                contactName="Shubham"
            });

            int count=obj.Count;
            int i=0;
            while(i<count)
            {
                Console.WriteLine(obj[i].contactId+" "+obj[i].contactName);
                i++;
            } 



              //Deleting the Record

            int target = 1;
 
        bool isExist = bool [target].contactName="Deepti";
        if (isExist) {
            Console.WriteLine("Element found in the list");
        }
        else {
            Console.WriteLine("Element not found in the given list");
        }

        }    
}
}