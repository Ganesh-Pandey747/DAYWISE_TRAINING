using Microsoft.AspNetCore.Mvc;
using employeeservice.Models;
namespace employeeservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController:ControllerBase
    {
        [HttpPost("Create")]
        public Employee CreateEmployee(Employee empobj)
        {
            return empobj;
        }        
    }
}