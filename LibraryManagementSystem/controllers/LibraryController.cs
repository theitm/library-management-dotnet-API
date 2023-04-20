using LibraryManagementSystem.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.models;
using LibraryManagementSystem.dto;
using System.Security.Policy;
using LibraryManagementSystem.services;
using LibraryManagementSystem.models.Entity;

namespace LibraryManagementSystem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly IBookRepository bookRepository;
        public LibraryController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<List<Book>> GetAllUser()
        {
            return await bookRepository.Get();
        }
        [HttpPost]
        public async Task<ActionResult> PostBook([FromBody] BookDTO books)
        {
            var newBook = await bookRepository.CreateBook(books);
            return Ok(newBook);
        }
        [HttpPut("update")]
        public async Task<ActionResult> PutBook(int id, [FromBody] PutBook books)
        {
           
            var res = await bookRepository.EditBook(id, books);
            if (res == null) return BadRequest("Book is not exist");
            return Ok(res);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            {
                try
                {
                    await bookRepository.Delete(id);

                    return NoContent();
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"lỗi khi xóa người dùng: {ex.Message}");

                }
            }
        }
        [HttpGet("search")]
        public async Task<IQueryable<Book>> GetSearchBook(string? Title, string? Author)
        {
            return await bookRepository.GetSearchBook(Title, Author);
        }


    }
}




