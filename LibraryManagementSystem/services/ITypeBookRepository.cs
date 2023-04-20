using LibraryManagementSystem.dto;

namespace LibraryManagementSystem.services
{
    public interface ITypeBookRepository
    {
        Task<TypeBookDTO> Create(CreateTypeBook createTypeBook);
        Task Update(PutTypeBook putTypeBook);
        Task Delete(int id);
    }
}
