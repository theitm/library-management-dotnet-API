using LibraryManagementSystem.Context;
using LibraryManagementSystem.dto;
using LibraryManagementSystem.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using LibraryManagementSystem.models.Entity;

namespace LibraryManagementSystem.services
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryManagementSystemDbContext _context;
        public BookRepository(LibraryManagementSystemDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> Get()
        {
            return await _context.Book.ToListAsync();
        }
        public async Task<BookDTO> CreateBook(BookDTO books)
        {
            var addBook = new Book()
            {
                Title = books.Title,
                Author = books.Author,
                Publication_date = books.Publication_date,
                Publisher = books.Publisher,
                Quantity = books.Quantity,
                Type_ID = books.Type_ID,
                Date_created = books.Date_created,
                Date_updated = books.Date_updated,
            };

            _context.Book.Add(addBook);
            await _context.SaveChangesAsync();

           return books;
        }
        public async Task<object> EditBook(int id, PutBook books)
        {
            var editBook = await _context.Book.FindAsync(id);
            if (editBook == null) return null;

            editBook.Title = books.Title;
            editBook.Author = books.Author;
            editBook.Publication_date = books.Publication_date;
            editBook.Publisher = books.Publisher;
            editBook.Quantity = books.Quantity;
            editBook.Type_ID = books.Type_ID;
            editBook.Date_created = books.Date_created;
            editBook.Date_updated = books.Date_updated;
            await _context.SaveChangesAsync();
            return books;
        }

        public async Task Delete(int id)
        {
            var bookToDelete = await _context.Book.FindAsync(id);
            _context.Book.Remove(bookToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IQueryable<Book>> GetSearchBook(string Title, string Author)
        {
            var allDataBook = _context.Set<Book>().AsNoTracking();

            if (Title != null)
            {
                allDataBook = allDataBook.Where(x => x.Title.Contains(Title));
            }

            if (Author != null)
            {
                allDataBook = allDataBook.Where(x => x.Author.Contains(Author));
            }

            return allDataBook;
        }

    }
}










