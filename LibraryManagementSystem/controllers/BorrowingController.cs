using LibraryManagementSystem.dto;
using LibraryManagementSystem.models.Entity;
using LibraryManagementSystem.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowingController : ControllerBase
    {
        private readonly IBorrowingRepository borrowingRepository;

        public BorrowingController(IBorrowingRepository borrowingRepository)
        {
            this.borrowingRepository = borrowingRepository;

        }
        [HttpPost]
        public async Task<ActionResult> PostUser([FromBody] CreateBorrowing createBorrowing)
        {
            var newBorrowing = await borrowingRepository.Create(createBorrowing);
            return Ok(newBorrowing);
        }
        [HttpGet]
        public async Task<IEnumerable<Borrowing>> GetAllBorrowing()
        {
            return await borrowingRepository.Get();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetById(int id)
        {
            var user = await borrowingRepository.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var bookDelete = await borrowingRepository.GetById(id);
            if (bookDelete == null) return NotFound();
            await borrowingRepository.Delete(bookDelete.Borrowing_ID);
            return Ok("Borrowing Deleted");
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateUser(int id, [FromBody] UpdateBorrowing updateBorrowing)
        {
            var borrowing = await borrowingRepository.GetById(id);

            if (borrowing == null || id != borrowing.Borrowing_ID)
            {
                return BadRequest();
            }
            await borrowingRepository.Update(id, updateBorrowing);
            return Ok("Updated");
        }
    }
}