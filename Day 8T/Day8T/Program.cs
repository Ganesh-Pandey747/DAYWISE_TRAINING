using Day8T.AdvDelegate;
using System;
//delegate string NameDelegate(string N);
//delegate void PhoneDelegate();
//delegate bool StudyDelegate();

namespace Day8T
{
    class Program
    {
        static void Main()
        {
         //Study sObj= new Study();
         //NameDelegate nameDelegate=new NameDelegate(sObj.Name);
         //var n= nameDelegate.Invoke("Ganesh");
         //System.Console.WriteLine(n);
         
         Study sObj=new Study();
         Func<string, string> func= sObj.Name;
         string fob = func("Ganesh");
         System.Console.WriteLine(fob);

         Action Obj = sObj.PhoneNo;
         Obj();

         Predicate<string> Pobj= sObj.StudyStatus;
         bool pd=Pobj("Shubham");
         System.Console.WriteLine(pd);
        }
    }
}
