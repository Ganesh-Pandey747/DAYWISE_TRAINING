using System;
using System.Threading;
using System.Threading.Tasks;
namespace Tplprogram
{
    class Myapp
    {                       
        public static void LongTask()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Long Task takes 7 sec to complete work");
            
        }
        public static async void myTask()
        {
            //Task task=new Task(new Action(LongTask));
            //task.Start();
            await Task.Run(new Action(LongTask));// new thread generated
            Console.WriteLine("New Thread");
        }
        public static void Main()
        {
            myTask();
            System.Console.WriteLine("I m in main method");
            Console.ReadLine();
                       
        }
    }
}
