using LibraryManagementSystem.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LibraryManagementSystem.models.LibraryManagementSystem;
using LibraryManagementSystem.dto;

namespace LibraryManagementSystem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly LibraryManagementSystemDbContext _context;
        public LibraryController(LibraryManagementSystemDbContext context)
        {
            _context = context;
        }
        //[HttpGet("{id}")]
        //public ActionResult<Book> GetBook(int id)
        //{


        //    var book = new Book { book_id = id, title = "Book Title", author = "Book Author", quantity = 50 };

        //    return book;
        //}

        [HttpPost("/addbook")]
        public async Task<ActionResult<Books>> AddBook(Books book)
        {
            books newBook = new books();
            newBook.book_id = book.book_id;
            newBook.title = book.title;
            newBook.author = book.author;
            newBook.publisher = book.publisher;
            newBook.publication = book.publication;
            newBook.quantity = book.quantity;
            newBook.type_book = book.type_book;
            newBook.date_update = book.date_update;
            newBook.date_created = book.date_created;

            _context.books.Add(newBook);
            await _context.SaveChangesAsync();
            return Ok("add new book");
        }
        //Edit book
        [HttpPut("/Edit/{id}")]
        public async Task<IActionResult> EditBook(int id, Books book)
        {
            books book1 = await _context.books.FindAsync(id);

            if (book == null)
            {
                return BadRequest();
            }

            book1.title = book.title;
            book1.author = book.author;
            book1.publisher = book.publisher;
            book1.publication = book.publication;
            book1.quantity = book.quantity;
            book1.type_book = book.type_book;
            book1.date_update = book.date_update;
            book1.date_created = book.date_created;
           
           
            await _context.SaveChangesAsync();

            return Ok("Book info was edit!");
           
        }

        //[HttpPost("/Book/Edit/{id}")]
        //public async Task<IActionResult> Edit(int id, books book)
        //{
        //    if (id != books.id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(Books);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!NhanvienExists(nhanvien.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(books);
        //}

        // DELETE: Book
        [HttpDelete("/DeleteBook/{id}")]
        public async Task<ActionResult> DeleteBook(int id)
        {
            {
                books book = await _context.books.FindAsync(id);

                if (book == null)
                {
                    return NotFound();
                }

                _context.books.Remove(book);
                await _context.SaveChangesAsync();

                return Ok("Book info was deleted !");
            }
        }

    }
}


