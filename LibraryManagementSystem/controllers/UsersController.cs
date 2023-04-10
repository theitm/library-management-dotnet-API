using LibraryManagementSystem.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.dto;
using LibraryManagementSystem.services;
using static LibraryManagementSystem.models.Users;

namespace LibraryManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository usersRepository;

        public UsersController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        //GET: api/user
        [HttpGet("/user")]
        public async Task<IEnumerable<Users>> GetAllUser()
        {
            return await usersRepository.Get();
        }

        //// POST: api/user
        [HttpPost("/user")]
        public async Task<ActionResult> PostUser([FromBody] CreateUser createUser)
        {
            var newUser = await usersRepository.Create(createUser);
            return Ok(newUser);
        }
        //delete user
        [HttpDelete("/user/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                await usersRepository.Delete(id);
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
        public async Task<ActionResult<Users>> GetById(int id)
        {
            var user = await usersRepository.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
        [HttpPut("/user/{id}")]
        public async Task<ActionResult> PutUser(int id, [FromBody] PutUser putUser)
        {
            if (id != putUser.user_id)
            {
                return BadRequest();
            }
            await usersRepository.Update(putUser);
            return NoContent();
        }

    }
}

