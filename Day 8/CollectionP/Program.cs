using System;
using CollectionP.Models;
using CollectionP.EmployeeList;


namespace CollectionP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp= new Employee();
            emp.EmpId=101;
            emp.EmpName="Ganesh";
            emp.Empsalary=1000;

            Employee emp1= new Employee();
            emp1.EmpId=111;
            emp1.EmpName="kumar";
            emp1.Empsalary=2000;



           // EmployeeList employeeList=new EmployeeList();
           EmpList obj1= new EmpList();
           obj1.AddEmployee(emp);
           obj1.AddEmployee(emp1);

          var temp= obj1.EmpDisplayList();
          foreach(var i in temp)
          {
              Console.WriteLine(i.EmpId+""+i.EmpName+""+i.Empsalary);
          }
            
             Employee empsearch= obj1.EmpSearch(111);
             Console.WriteLine(empsearch.EmpId+""+empsearch.EmpName+""+empsearch.Empsalary);
            

        }
    }
}