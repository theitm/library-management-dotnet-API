using LibraryManagementSystem.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.dto;
using LibraryManagementSystem.services;
using LibraryManagementSystem.models.Entity;

namespace LibraryManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        //GET: api/user
        [HttpGet("/user")]
        public async Task<IEnumerable<User>> GetAllUser()
        {
            return await userRepository.Get();
        }
        //// POST: api/user
        [HttpPost("/user")]
        public async Task<ActionResult> PostUser([FromBody] CreateUser createUser)
        {
            var newUser = await userRepository.Create(createUser);
            return Ok(newUser);
        }
        //DELETE user
        [HttpDelete("/user/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                await userRepository.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                // Log the error message and return an appropriate response
                return StatusCode(500, $"lỗi khi xóa người dùng: {ex.Message}");
            }
        }
        //Get manager by id
        [HttpGet("/manager/{id}")]
        public async Task<ActionResult<User>> GetById(int id)
        {
            var user = await userRepository.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPut("/user/{id}")]
        public async Task<ActionResult> PutUser(int id, [FromBody] PutUser putUser)
        {
            if (id != putUser.User_ID)
            {
                return BadRequest();
            }
            await userRepository.Update(putUser);
            return NoContent();
        }
    }
}

