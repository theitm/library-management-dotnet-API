using LibraryManagementSystem.Context;
using LibraryManagementSystem.dto;
using LibraryManagementSystem.models.Entity;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.services
{
    public class BorrowingRepository : IBorrowingRepository
    {
        private readonly LibraryManagementSystemDbContext _context;
        public BorrowingRepository(LibraryManagementSystemDbContext context)
        {
            _context = context;
        }

        public async Task<BorrowingDTO> Create(CreateBorrowing createBorrowing)
        {
            var createData = new Borrowing()
            {
                User_ID = createBorrowing.User_ID,
                Borrowing_date = createBorrowing.Borrowing_date,
                Due_date = createBorrowing.Due_date,
                Returning_date = createBorrowing.Returning_date,
                Date_created = createBorrowing.Date_created,
                Date_updated = createBorrowing.Date_updated,
            };
            _context.Borrowing.Add(createData);
            await _context.SaveChangesAsync();
            var data = new BorrowingDTO()
            {
                User_ID = createBorrowing.User_ID,
                Borrowing_date = createBorrowing.Borrowing_date,
                Due_date = createBorrowing.Due_date,
                Date_created = createBorrowing.Date_created,
                Date_updated = createBorrowing.Date_updated,
            };
            return data;
        }
        async Task<IEnumerable<Borrowing>> IBorrowingRepository.Get()
        {
            return await _context.Borrowing.ToListAsync();
        }
        async Task IBorrowingRepository.Delete(int id)
        {
            var DeleteBorrowing = await _context.Borrowing.FindAsync(id);
            _context.Borrowing.Remove(DeleteBorrowing);
            await _context.SaveChangesAsync();
        }
        async Task<Borrowing> IBorrowingRepository.GetById(int id)
        {
            return await _context.Borrowing.FindAsync(id);
        }
        public async Task Update(int id, UpdateBorrowing updateBorrowing)
        {
            Borrowing borrowing = await _context.Borrowing.FindAsync(id);

            borrowing.Borrowing_date = updateBorrowing.Borrowing_date;
            borrowing.Due_date = updateBorrowing.Due_date;
            borrowing.Returning_date = updateBorrowing.Returning_date;
    
            _context.Borrowing.Update(borrowing);
            await _context.SaveChangesAsync();
        }
    }
 }

