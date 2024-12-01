using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YogaApplicationApi.Models;

namespace YogaApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public AuthenticationController(ApplicationDbContext context) => _context = context;
        
      // [HttpGet]
      // public async Task<IEnumerable<RegisterViewModel>> Get() => await _context.Users.ToListAsync();

        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return user == null ? NotFound() : Ok(user);

        }
        [HttpPost]
        public async Task<IActionResult> Create(RegisterViewModel model)
        {           
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = model.Id });
        }
    }
}
