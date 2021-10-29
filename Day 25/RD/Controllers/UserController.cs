using Microsoft.AspNetCore.Mvc;
namespace RD.Controllers
{
[ApiController]
[Route("Taazaa/[controller]")]
    public class UserController:ControllerBase //
    {
        [HttpGet]
        [Route("fetch/{id:int}")]
        public IActionResult FetchData(int? id)
        {
            return Ok(id);
        }
        
    }
}