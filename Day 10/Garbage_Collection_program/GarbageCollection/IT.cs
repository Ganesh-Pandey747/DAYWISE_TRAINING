using System;
namespace Garbage_Collection_program.GarbageCollection
{
    public class IT:IDisposable
    {
      public void databaseCollect() //to connect to database we need so many resources
      {
          System.Console.WriteLine("let me write a code to connect to database");
      }

        public void Dispose()
        {
           System.Console.WriteLine("Destructor is working now");
        }
        /* ~ IT() // Finalize- act as a destructor
      {
          System.Console.WriteLine("Destructor is working now");
      }  */ 
    }
}