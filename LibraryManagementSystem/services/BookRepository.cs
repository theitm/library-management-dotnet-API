using LibraryManagementSystem.dto;
using LibraryManagementSystem.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;

namespace LibraryManagementSystem.services
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryManagementSystemDbContext _context;
        public BookRepository(LibraryManagementSystemDbContext context)
        {
            _context = context;
        }

        public async Task<List<books>> Get()
        {
            return await _context.books.ToListAsync();
        }


        public async Task<Books> CreateBook(Books books)
        {


            var addBook = new books()
            {
                //book_id = books.book_id,
                title = books.title,
                author = books.author,
                publication = books.publication,
                publisher = books.publisher,
                quantity = books.quantity,
                type_book = books.type_book,
                date_created = books.date_created,
                date_update = books.date_update,
            };

            _context.books.Add(addBook);
            await _context.SaveChangesAsync();

            return books;

        }
        public async Task<object> EditBook(int id, PutBooks books)
        {
            var editBook = await _context.books.FindAsync(id);
            if (editBook == null) return null;

            editBook.title = books.title;
            editBook.author = books.author;
            editBook.publication = books.publication;
            editBook.publisher = books.publication;
            editBook.quantity = books.quantity;
            editBook.type_book = books.type_book;
            editBook.date_created = books.date_created;
            editBook.date_update = books.date_update;
            //var EditBook = new books()
            //{
            //    //book_id = books.book_id,
            //    title = books.title,
            //    author = books.author,
            //    publication = books.publication,
            //    publisher = books.publisher,
            //    quantity = books.quantity,
            //    type_book = books.type_book,
            //    date_created = books.date_created,
            //    date_update = books.date_update,
            //};


            await _context.SaveChangesAsync();
            return books;
        }
        //public async Task<Books> GetById(int id )
        //{
        //    return await _context.books.FindAsync(id);
        //}
        public async Task Delete(int id)
        {
            var bookToDelete = await _context.books.FindAsync(id);
            _context.books.Remove(bookToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IQueryable<books>> GetSearchBook(string title, string author)
        {
            var allDataBook =  _context.Set<books>().AsNoTracking();

            if (title != null)
            {
                allDataBook =   allDataBook.Where(x => x.title.Contains(title));
            }

            if(author != null)
            {
                allDataBook = allDataBook.Where(x => x.author.Contains(author));
            }

            return allDataBook;
            }

        }

    }
    

    



