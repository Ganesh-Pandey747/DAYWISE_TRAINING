using Employee_Repo.Models;
using  System.Linq;
using System.Collections.Generic;
namespace Employee_Repo.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> emplist=new List<Employee>();

        void IEmployeeRepository.Add(Employee employee)
        {
            emplist.Add(employee);
        }

        Employee IEmployeeRepository.Find(int Id)
        {
           var employee =emplist.Where(ctr=>ctr.EmpId==Id).SingleOrDefault();
            return employee ;
        }
        List<Employee> IEmployeeRepository.GetAll()
        {
            return emplist;
        }

        void IEmployeeRepository.Remove(int id)
        {
            var EmployeeToRemove =emplist.Where(ctr=>ctr.EmpId==id).SingleOrDefault();
           if(EmployeeToRemove!=null)
           {
               emplist.Remove(EmployeeToRemove);
           } 
          
        }

        void IEmployeeRepository.Update(Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}