using LibraryManagementSystem.Context;
using LibraryManagementSystem.dto;
using LibraryManagementSystem.models.Entity;

namespace LibraryManagementSystem.services
{
    public class BorrowingRepository : IBorrowingRepository
    {
        private readonly LibraryManagementSystemDbContext _context;
        public BorrowingRepository(LibraryManagementSystemDbContext context)
        {
            _context = context;
        }
        public async Task<BorrowingDTO> Create(BorrowingDTO createBorrowing)
        {
            var createData = new Borrowing()
            {
                Borrowing_Id = createBorrowing.Borrowing_Id,
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
                User_ID = createBorrowing.User_ID
            };
            return data;
        }
    }
}
