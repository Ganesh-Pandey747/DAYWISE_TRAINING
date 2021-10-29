using System;
using System.Threading.Tasks;
using System.Threading;

namespace TPL
{
    class MyApp
    {
        public static void longTask()//act as dbcontext
        {
            Thread.Sleep(20000); // sleep for 20 sec
            
        }

        public async static void myCall() //act as repository
        {
            await Task.Run(new Action(longTask));
            System.Console.WriteLine("At this point your thread has been created");
        }
       
              
        public static void Main()  // act as controller
        {
           myCall();
           System.Console.WriteLine("I m main thread");
           Console.ReadLine();
        }
    }
}
