using Employee_Repo.Models;
using System.Collections.Generic;
namespace Employee_Repo.Repository
{
    public interface IEmployeeRepository
    {
      void Add(Employee employee);
      void Update(Employee employee);
      List<Employee> GetAll();
      Employee Find(int Id);

      void Remove(int id);
    }
}