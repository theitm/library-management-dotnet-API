using LibraryManagementSystem.Context;
using LibraryManagementSystem.dto;
using LibraryManagementSystem.models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.services
{
    public class ReturningRepository : IReturningRepository
    {
        private readonly LibraryManagementSystemDbContext _context;

        public ReturningRepository(LibraryManagementSystemDbContext context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<Returning>>Get()
        {
            return await _context.Returning.ToListAsync();
        }

        public async Task<Returning> GetById(int id)
        {
            return await _context.Returning.FindAsync(id);
        }

        public async Task<ReturningDTO> Create(CreateReturning createReturning)
        {
            var createData = new Returning()
            {
                Borrowing_ID = createReturning.Borrowing_ID,
                Returning_date = createReturning.Returning_date,
                Quantity = createReturning.Quantity,
                Lost_book = createReturning.Lost_book,
                Date_created = createReturning.Date_created,
                Date_updated = createReturning.Date_updated

            };
            _context.Returning.Add(createData);
            await _context.SaveChangesAsync();
            var data = new ReturningDTO()
            {
                Borrowing_ID = createReturning.Borrowing_ID,
                Returning_date = createReturning.Returning_date,
                Quantity = createReturning.Quantity,
                Lost_book = createReturning.Lost_book,
                Date_created = createReturning.Date_created,
                Date_updated = createReturning.Date_updated
            };
            return data;
            
        }
       
        public async Task Update(int id, PutReturning updateReturning)
        { 
            var returning = await _context.Returning.FindAsync(id);
            DateTime date = DateTime.Now;

            returning.Returning_date = updateReturning.Returning_date;
            returning.Quantity = updateReturning.Quantity;
            returning.Lost_book = updateReturning.Lost_book;
            returning.Date_updated = date;

            _context.Returning.Update(returning);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var DeleteReturning = await _context.Returning.FindAsync(id);
            _context.Returning.Remove(DeleteReturning);
            await _context.SaveChangesAsync();
        }
    }
}
