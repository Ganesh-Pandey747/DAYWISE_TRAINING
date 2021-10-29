using System.Collections.Generic;
namespace EmployeeService.Model
{
    public class EmployeeData
    {
        public List<Employee> EmployeeDetails()
        {
            List<Employee> obj =new List<Employee>();
            obj.Add(new Employee
            {
                pho=256,
                name="Ganesh"

            });
            obj.Add(new Employee
            {
                pho=156,
                name="Nikhil"

            });
            return obj;
        }
    }
}