using LibraryManagementSystem.dto;
using LibraryManagementSystem.models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.services
{
    public interface IBorrowingRepository
    {
        Task<IEnumerable<Borrowing>> Get();
        Task<Borrowing> GetById(int id);
        Task<BorrowingDTO> Create(CreateBorrowing createBorrowing);
        Task Update(int id, UpdateBorrowing updateBorrowing);
        Task Delete(int id);
    }
}