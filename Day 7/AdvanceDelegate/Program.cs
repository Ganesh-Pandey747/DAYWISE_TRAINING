using System;
using AdvanceDelegate.Arithmetic;
delegate void Cal(double D1, double D2);
namespace AdvanceDelegate
{
    class Program
    {
        static void Main()
        {
//Cal obj=new Cal(Arithmetic.Addition);
         //  obj.Invoke(10,20.5);

        // Anonymous method 
         
          Cal mycal=(double d1, double d2)=> // lambda function
          {
              System.Console.WriteLine(d1*d2);
          };
          Cal div = delegate(double d1, double d2) //anonymous function
          {
              System.Console.WriteLine(d1/d2);    
          };
          mycal(10,20);
          div(10,2);
        }

    }
}
