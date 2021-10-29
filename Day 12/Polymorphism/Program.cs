using System;
namespace Polymorphism
{
    class Person
    {  // example of method overloading
        public int walk(int a) // int type
        {
            return a;
        }

       /*  public string walk(string a)// string type
        {
            return a;

        } */
    }
    class Program
    {
        static void Main()
        {
            Person person=new Person();
            int a = person.walk(12);// association of anobject with method  is early binding
            // association of an object with the overloaded function
            //string b =person.walk("Cyber Park");
            System.Console.WriteLine("in "+" "+a+" km");
        
        }
    }
}
