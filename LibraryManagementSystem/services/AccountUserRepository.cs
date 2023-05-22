
using LibraryManagementSystem.dto;
using LibraryManagementSystem.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LibraryManagementSystem.Context;
using LibraryManagementSystem.models.Entity;

namespace LibraryManagementSystem.services
{
    public class AccountUserRepository : IAccountUserRepository
    {
        private readonly LibraryManagementSystemDbContext _context;

        public AccountUserRepository(LibraryManagementSystemDbContext context)
        {
            _context = context;
        }
        //CREATE
        public async Task<UserDTO> Create(CreateUser createUser)
        {

            string username = createUser.Name;
            string[] nameParts = username.Split(' ');
            string firstName = nameParts.LastOrDefault() ?? "";
            string lastName = string.Join(" ", nameParts.Take(nameParts.Length - 1));
            string initials = string.Concat(lastName.Split().Select(Name => Name.Substring(0, 1).ToLower()));
            string userAccount = $"{initials}{firstName}";
            string userOld = userAccount;

            var checkName = from n in _context.User.Where(n => n.Username.Equals(userAccount))
                            select n;
            int suffix = 1;
            while (checkName.Any(u => u.Username == userAccount))
            {
                userAccount = $"{userOld}{suffix}";
                suffix++;
            }
            DateTime currentDate = DateTime.Now;
            var createData = new User()
            {
                Name = createUser.Name,
                Username = userAccount,
                Password = createUser.Password,
                Address = createUser.Address,
                Phone_number = createUser.Phone_number,
                Email = createUser.Email,
                Access_level = createUser.Access_level,
                Date_of_birth = createUser.Date_of_birth,
                Date_created = currentDate,
                Date_update = currentDate,
            };
            _context.User.Add(createData);
            await _context.SaveChangesAsync();

            var data = new UserDTO()
            {
                Name = createUser.Name,
                Username = userAccount,
                Address = createUser.Address,
                Phone_number = createUser.Phone_number,
                Email = createUser.Email,
                Access_level = createUser.Access_level,
                Date_of_birth = createUser.Date_of_birth,
                Date_created = currentDate,
                Date_update = currentDate,
            };
            return data;
        }
        //DELETE
        public async Task Delete(int User_ID)
        {
            var userToDelete = await _context.User.FindAsync(User_ID);
            _context.User.Remove(userToDelete);
            await _context.SaveChangesAsync();
        }
        //GET ALL
        public async Task<IEnumerable<User>> Get()
        {
            return await _context.User.ToListAsync();
        }
        //GET BY ID
        public async Task<User> GetById(int User_ID)
        {
            return await _context.User.FindAsync(User_ID);
        }
        //UPDATE
        public async Task Update(PutUser putUser)
        {
            string username = putUser.Name;
            string[] nameParts = username.Split(' ');
            string firstName = nameParts.LastOrDefault() ?? "";
            string lastName = string.Join(" ", nameParts.Take(nameParts.Length - 1));
            string initials = string.Concat(lastName.Split().Select(Name => Name.Substring(0, 1).ToLower()));
            string userAccount = $"{initials}{firstName}";
            string userOld = userAccount;
            var checkUserName = from n in _context.User.Where(n => n.Username.Equals(userAccount))
                                select n;
            int suffix = 1;
            while (checkUserName.Any(u => u.Username == userAccount))
            {
                userAccount = $"{userOld}{suffix}";
                suffix++;
            }
            DateTime currentDate = DateTime.Now;
            var createData = new User()
            {
                User_ID = putUser.User_ID,
                Name = putUser.Name,
                Username = userAccount,
                Address = putUser.Address,
                Phone_number = putUser.Phone_number,
                Email = putUser.Email,
                Access_level = putUser.Access_level,
                Date_of_birth = putUser.Date_of_birth,
                Date_update = currentDate,
            };
            _context.Entry(createData).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

    }
}
