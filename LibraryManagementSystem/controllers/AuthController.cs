using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly LibraryManagementContext _context;

    public AuthController(LibraryManagementContext context)
    {
        _context = context;
    }

    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> Login([FromBody] Users model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == model.Username && u.Password == model.Password);

        if (user == null)
        {
            return BadRequest("Invalid username or password");
        }

        return Ok(new Users { Id = user.Id, Username = user.Username, Password = user.Password, Role = user.Role });
    }
}
