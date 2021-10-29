// difference between finalize and dispose
using System;
using Garbage_Collection_program.GarbageCollection;

namespace Garbage_Collection_program
{
    class Program
    {
        public static void Main()
        {//we are defining the scope of an object using block
           using (IT iT= new IT())
           {
               iT.databaseCollect(); // now the function is called, got the value , still resources are running this is where garbage collection comes in picture
           } //at this point dispose fn will be called explicitly
           
           System.Console.WriteLine("End of the program");      
        }             
    }
}
