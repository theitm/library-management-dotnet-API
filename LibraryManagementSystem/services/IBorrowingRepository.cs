using LibraryManagementSystem.dto;

namespace LibraryManagementSystem.services
{
    public interface IBorrowingRepository
    {
        //Task<IEnumerable<Borrowing>> Get();
        //Task<Borrowing> GetById(int id);
        Task<BorrowingDTO> Create(BorrowingDTO createBorrowing);
        //Task Update(UpdateBorrowing updateBorrowing);
        //Task Delete(int id);

    }
}
