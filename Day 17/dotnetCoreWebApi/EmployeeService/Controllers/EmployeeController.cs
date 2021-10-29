using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EmployeeService.Model;
using System;

namespace EmployeeService.Controllers
{
    [Route("[controller")]
    public class EmployeeController:ControllerBase
    {
      [HttpGet("info")]
      public List<Employee> Details()
      {
          EmployeeData obj = new EmployeeData();
          List<Employee> temp=obj.EmployeeDetails();
          return temp;
      }  
    }
}