using LibraryManageSys.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LibraryManageSys.models.LibraryManageSys;
using LibraryManagementSystem.dto;

namespace LibraryManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryManageSysController : ControllerBase
    {
        private readonly LibraryManageSysDbContext _context;

        public LibraryManageSysController(LibraryManageSysDbContext context)
        {
            _context = context;
        }

        [HttpGet("/borrowing-list")]
        public async Task<ActionResult<IEnumerable<object>>> Getborrowingss()
        {
            return await _context.borrowings
            .Include(b => b.books)
            .Include(b => b.users)
            .Select(b => new {
                b.borrowingID,
                BookTitle = b.books.title, // Include the book title from the Books entity
                b.userID,
                UserName = b.users.Name, // Include the user name from the Users entity
                b.quantity,
                b.borrowings_date,
                b.due_date,
                b.date_update,
                b.date_created
            })
            .ToListAsync();
        }

        [HttpGet("/borrowing-by-id/{id}")]
        public async Task<ActionResult<object>> Getborrowings(int id)
        {
            var result = await _context.borrowings
               .Include(b => b.books)
               .Include(b => b.users)
               .Where(b => b.borrowingID == id)
               .Select(b => new {
                   b.borrowingID,
                   BookTitle = b.books.title, // Include the book title from the Books entity
                   b.userID,
                   UserName = b.users.Name, // Include the user name from the Users entity
                   b.quantity,
                   b.borrowings_date,
                   b.due_date,
                   b.date_update,
                   b.date_created
               })
               .FirstOrDefaultAsync();

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpPost("/borrowing")]
        public async Task<ActionResult<Borrowings>> Createborrowing(BookBorrowing borrowings)
        {
            // Query user
            Users user = await _context.users.FindAsync(borrowings.userID);

            // Query Book
            Books book = await _context.books.FindAsync(borrowings.bookID);

            Borrowings borrowings1 = new Borrowings();
            borrowings1.users = user;
            borrowings1.books = book;
            borrowings1.bookID = borrowings.bookID;
            borrowings1.userID = borrowings.userID;
            borrowings1.quantity = borrowings.quantity;
            borrowings1.borrowings_date = borrowings.borrowings_date;
            borrowings1.due_date = borrowings.due_date;
            borrowings1.date_update = borrowings.date_update;
            borrowings1.date_created = borrowings.date_created;

            _context.borrowings.Add(borrowings1);
            await _context.SaveChangesAsync();

            return Ok("New Borrowing request was created !");
        }

        [HttpPut("/update-borrowing/{id}")]
        public async Task<IActionResult> Updateborrowings(int id, BookBorrowing borrowings)
        {
            Borrowings borrowing = await _context.borrowings.FindAsync(id);

            if (borrowing == null)
            {
                return BadRequest();
            }

            // Query user
            Users user = await _context.users.FindAsync(borrowings.userID);

            // Query Book
            Books book = await _context.books.FindAsync(borrowings.bookID);

            // Update the borrowing object with the new values
            borrowing.users = user;
            borrowing.books = book;
            borrowing.bookID = borrowings.bookID;
            borrowing.userID = borrowings.userID;
            borrowing.quantity = borrowings.quantity;
            borrowing.borrowings_date = borrowings.borrowings_date;
            borrowing.due_date = borrowings.due_date;
            borrowing.date_update = borrowings.date_update;
            borrowing.date_created = borrowings.date_created;

            // Save the changes to the database
            await _context.SaveChangesAsync();

            return Ok("Borrowing info was updated !");
        }

        [HttpDelete("/remove-borrowing/{id}")]
        public async Task<IActionResult> Deleteborrowings(int id)
        {
            Borrowings borrowings = await _context.borrowings.FindAsync(id);

            if (borrowings == null)
            {
                return NotFound();
            }

            _context.borrowings.Remove(borrowings);
            await _context.SaveChangesAsync();

            return Ok("Borrowing info was deleted !");
        }
    }
}
