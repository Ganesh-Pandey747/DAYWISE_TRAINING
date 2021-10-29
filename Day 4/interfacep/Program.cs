using System;
using interfacep.Night;
using interfacep.Person_son;
namespace interfacep
{
    class Program
    {
        static void Main(string[] args)
        {
             INight obj= new Person();
             int temp=obj.study();
             Console.WriteLine(temp);
     
        }
    }
}
