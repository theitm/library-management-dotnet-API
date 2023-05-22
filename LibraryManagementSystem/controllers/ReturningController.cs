using LibraryManagementSystem.dto;
using LibraryManagementSystem.models.Entity;
using LibraryManagementSystem.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReturningController : ControllerBase
    {
        private readonly IReturningRepository returningRepository;

        public ReturningController(IReturningRepository returningRepository)
        {
            this.returningRepository = returningRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Returning>> GetAllReturning()
        {
            return await returningRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Returning>> GetById(int id)
        {
            var returning = await returningRepository.GetById(id);

            if (returning == null)
            {
                return NotFound();
            }

            return Ok(returning);
        }

        [HttpPost]
        public async Task<ActionResult> PostReturning([FromBody] CreateReturning createReturning)
        {
            var newReturning = await returningRepository.Create(createReturning);
            return Ok(newReturning);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateReturning(int id, [FromBody] PutReturning putReturning)
        {
            var returning = await returningRepository.GetById(id);

            if (returning == null || id != returning.Returning_ID)
            {
                return NotFound();
            }
            await returningRepository.Update(id, putReturning);
            return Ok(returning);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleteReturning = await returningRepository.GetById(id);
            if (deleteReturning == null) return NotFound();
            await returningRepository.Delete(id);
            return Ok("Borrowing Deleted");
        }
    }
}
