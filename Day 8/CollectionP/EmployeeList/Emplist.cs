using System.Collections.Generic;
using CollectionP.Models;
using CollectionP.EmployeeList;

namespace CollectionP.EmployeeList
{
    public class EmpList : IEmployee
    {
        List<Employee> list= new List<Employee>();

        public void AddEmployee(Employee obj)
        {
            list.Add(obj);
        }
         public List<Employee> EmpDisplayList()
         {
             return list;
         }
         public Employee EmpSearch(int empId)
         {             
            return list.Find(e=>e.EmpId==empId);
         }
        
    }
}