using EmployeeService.Models;
using Microsoft.AspNetCore.Mvc;
using EmployeeService.Repository;


namespace EmployeeService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController:ControllerBase
    {
        IEmployeeList list1;
        public EmployeeController(IEmployeeList ilist)
        {
            list1=ilist;
        }
        [HttpPost]
        public Employee CreateEmployeeData(Employee temp)
        {
            var t=list1.CreateEmployee(temp);
            if(t==1)
            {
                return temp;
            }
            return temp;
        }
        
    }
}