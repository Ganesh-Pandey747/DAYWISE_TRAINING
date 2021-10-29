using System;
using System.Threading;
namespace Tplprogram
{
    class Myapp
    {
        public static void LongTask()
        {
            Thread.Sleep(6000);
            System.Console.WriteLine("Going to karolbagh for major work hopefully it will take time");
        }
        public static void Main()
        {
          Thread obj=new Thread(new ThreadStart(LongTask));
          obj.Start(); 
          Console.WriteLine("I m unside the main function");  
            
        }
    }
}
