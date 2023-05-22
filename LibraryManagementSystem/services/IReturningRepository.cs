using LibraryManagementSystem.dto;
using LibraryManagementSystem.models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.services
{
    public interface IReturningRepository
    {
        Task<IEnumerable<Returning>> Get();
        Task<Returning> GetById(int id);
        Task<ReturningDTO> Create(CreateReturning createReturning);
        Task Update(int id, PutReturning updateReturning);
        Task Delete(int id);
    }
}
