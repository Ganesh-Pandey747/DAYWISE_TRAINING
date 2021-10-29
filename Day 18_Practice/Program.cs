using System;
using System.Collections.Generic;

namespace dictonaryProgram
{
    class Program //implementation of all operations of dictionary
    {
        static void Main(string[] args)
        {
            //declaration of Dictionary
            var Details=new Dictionary<string,object>(); //here key is string type and value is of object type
    
            //Insertion operation in Dictionary
            //inserting value in dt
            Details.Add("Eid",101);
            Details.Add("Ename","Ganesh Pandey");
            Details.Add("Ephno",9506157010);
            Details.Add("Esalary",1000000.00);
            foreach(var val in Details)
            {
                System.Console.WriteLine("Key={0}", "Value={1}", val.Key,val.Value);
            }


            //update operation in Dictionary
            //update Ephno value
            
            Console.WriteLine("ephno old value :- "+Details["Ephno"]);
            Details["Ephno"]=6393085539;
            Console.WriteLine("ephno new value :- "+Details["Ephno"]);
            
            //delete operation in Dictionary
            int count=Details.Count;
            Console.WriteLine("old Details contains "+count+" elements");
            Details.Remove("Ephno");
            count=Details.Count;
            Console.WriteLine("new Details contains "+count+" elements");
            
            //search operation in Dictionary
            var val="Ganesh Pandey";
            if(Details.ContainsValue(val))
            {
                Console.WriteLine(val+"is found in Details");
            }           
        }
    }
}