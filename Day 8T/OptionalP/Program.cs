using System;

namespace OptionalP
{
    class Program
    {

         public static string Name_add(string str1,string str2="Ganesh")
        {
            return(str1+str2);
        }
        public static void Main()
        {
            Console.WriteLine(Name_add("Pandey"));
            Console.WriteLine(Name_add("Ganesh Pandey","Shubham"));
        }
    }
}
