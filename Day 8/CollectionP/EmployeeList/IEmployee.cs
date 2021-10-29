using System.Collections.Generic;
using CollectionP.Models;

namespace CollectionP.EmployeeList
{
    public interface IEmployee
    {
         void AddEmployee(Employee obj);
         List<Employee> EmpDisplayList();
         Employee EmpSearch(int empId);
    }
}