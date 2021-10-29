using EmployeeService.Models;
namespace EmployeeService.Repository
{
    public interface IEmployeeList
    {
        int CreateEmployee(Employee obj);
    }
}