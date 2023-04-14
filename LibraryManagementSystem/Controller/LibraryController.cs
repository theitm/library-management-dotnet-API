using LibraryManagementSystem.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  LibraryManagementSystem.models;
using LibraryManagementSystem.dto;
using System.Security.Policy;
using LibraryManagementSystem.services;

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
        public async Task<List<books>> GetAllUser()
        {
            return await bookRepository.Get();
        }


        [HttpPost]
        public async Task<ActionResult> PostBook([FromBody] Books books)
        {
            var newBook = await bookRepository.CreateBook(books);
            return Ok(newBook);
        }
        [HttpPut("update")]
        public async Task<ActionResult> PutBook(int id, [FromBody] PutBooks books)
        {
            //if (id != books.book_id)
            //{
            //    return BadRequest();
            //}
            var res = await bookRepository.EditBook(id, books);
            if (res == null) return BadRequest("Book is not exist");
            //return Ok("successfully");
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
                    // Log the error message and return an appropriate response
                    return StatusCode(500, $"lỗi khi xóa người dùng: {ex.Message}");

                }
            }
        }
        [HttpGet("search")]
        public async Task<IQueryable<books>> GetSearchBook( string? title, string? author)
        {
            return await bookRepository.GetSearchBook(title, author);
        }


    }
}



              
