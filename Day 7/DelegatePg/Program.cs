using System;
using Day7.Delegate;
delegate int customDelegate();
namespace Day7
{
    class Program
    {
        static void Main()
        {
            var Obj1= new Person();
            customDelegate cObj= new customDelegate(Obj1.PhoneNo);
            var temp1= cObj.Invoke();
            Console.WriteLine(temp1);

            cObj+=Obj1.Walk; //multicast+=
            var temp2= cObj.Invoke();
            Console.WriteLine(temp2);
            
        }
    }
}
