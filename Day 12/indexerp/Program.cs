using System;
using indexerp.employee;
namespace indexerp
{
    class Program
    {
        static void Main()
        {
            Employee employee=new Employee();
            employee.Empid=101; // at this point set will be called.. 
            System.Console.WriteLine(employee.Empid);
        }
    }
}
