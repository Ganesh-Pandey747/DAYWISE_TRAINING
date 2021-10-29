using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TokenAuthentication.Data;

namespace TokenAuthentication.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BookController: ControllerBase
    {
        private readonly TokenDbContext _context;
        public BookController( TokenDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult>GetBooks()
        {
            var data = await _context.Tblbooks.ToListAsync();
            return Ok(data);
        }
    }
}