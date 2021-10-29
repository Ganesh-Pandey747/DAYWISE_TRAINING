using System;
using DelegatePr.Noida;
delegate int customDelegate();

namespace DelegatePr
{
    class Program
    {
        static void Main()
        {
            var Obj1= new Broker();
            customDelegate cObj = new customDelegate(Obj1.Flat1);
            var temp1= cObj.Invoke();
            Console.WriteLine(temp1);

            cObj+=Obj1.Flat1;
            var temp2= cObj.Invoke();
            Console.WriteLine(temp2);
        }
    }
}
