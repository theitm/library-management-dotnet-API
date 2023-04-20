using LibraryManagementSystem.dto;
using LibraryManagementSystem.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeBookController : ControllerBase
    {
        private readonly ITypeBookRepository typeBookRepository;
        public TypeBookController(ITypeBookRepository typeBookRepository)
        {
            this.typeBookRepository = typeBookRepository;
        }
        //API POST TypeBook
        [HttpPost("/TypeBook")]
        public async Task<ActionResult> PostTypeBook([FromBody] CreateTypeBook createTypeBook)
        {
            var newTypeBook = await typeBookRepository.Create(createTypeBook);
            return Ok(newTypeBook);
        }
        //API PUT TypeBook
        [HttpPut("/TypeBook/{id}")]
        public async Task<ActionResult> PutTypeBook(int id, [FromBody] PutTypeBook putTypeBook)
        {
            if (id != putTypeBook.Type_ID)
            {
                return BadRequest();
            }
            await typeBookRepository.Update(putTypeBook);
            return NoContent();
        }
        //API DELETE TypeBook
        [HttpDelete("/TypeBook/{id}")]
        public async Task<IActionResult> DeleteTypeBook(int id)
        {
            try
            {
                await typeBookRepository.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                // Log the error message and return an appropriate response
                return StatusCode(500, $"lỗi khi xóa người dùng: {ex.Message}");
            }
        }
    }
}
