using LibraryManagementSystem.dto;
using LibraryManagementSystem.models;
using LibraryManagementSystem.models.Entity;
using static LibraryManagementSystem.models.Entity.User;

namespace LibraryManagementSystem.services
{
    public interface IAccountUserRepository
    {
        Task<IEnumerable<User>> Get();
        Task<User> GetById(int id);
        Task<UserDTO> Create(CreateUser createUser);
        Task Update(PutUser putuser);
        Task Delete(int id);
    }
}
