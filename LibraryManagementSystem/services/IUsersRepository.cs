using LibraryManagementSystem.dto;
using LibraryManagementSystem.models;
//using static LibraryManagementSystem.models.Users;

namespace LibraryManagementSystem.services
{
    public interface IUsersRepository
    {
        Task<IEnumerable<Users>> Get();
        Task<Users> GetById(int user_id);
        Task<UserDTO> Create(CreateUser createUser);
        Task Update(PutUser putuser);
        Task Delete(int user_id);

    }

}
