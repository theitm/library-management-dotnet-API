
using LibraryManagementSystem.dto;
using LibraryManagementSystem.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using static LibraryManagementSystem.models.Users;

namespace LibraryManagementSystem.services
{
    public class UsersRepository : IUsersRepository
    {
        private readonly LibraryManagementSystemDbContext _context;

        public UsersRepository(LibraryManagementSystemDbContext context)
        {
            _context = context;
        }

        public async Task<UserDTO> Create(CreateUser createUser)
        {

            string username = createUser.Name;
            string[] nameParts = username.Split(' ');
            string firstName = nameParts.LastOrDefault() ?? "";
            string lastName = string.Join(" ", nameParts.Take(nameParts.Length - 1));
            string initials = string.Concat(lastName.Split().Select(Name => Name.Substring(0, 1).ToLower()));
            string userAccount = $"{initials}{firstName}";
            string userOld = userAccount;

            var checkName = from n in _context.Users.Where(n => n.username.Equals(userAccount))
                                select n;
            int suffix = 1;
            while (checkName.Any(u => u.username == userAccount))
            {
                userAccount = $"{userOld}{suffix}";
                suffix++;
            }
            DateTime currentDate = DateTime.Now;
            var createData = new Users()
            {

                Name = createUser.Name,
                username = userAccount,
                password = createUser.password,
                address = createUser.address,
                phone_number = createUser.phone_number,
                email = createUser.email,
                access_level = createUser.access_level,
                date_of_birth = createUser.date_of_birth,
                date_created = currentDate,
                date_update = currentDate,
        };
            _context.Users.Add(createData);
            await _context.SaveChangesAsync();


            var data = new UserDTO()
            {
                Name = createUser.Name,
                username = userAccount,
                address = createUser.address,
                phone_number = createUser.phone_number,
                email = createUser.email,
                access_level = createUser.access_level,
                date_of_birth = createUser.date_of_birth,
                date_created = currentDate,
                date_update = currentDate,
            };

            return data;

        }
        public async Task Delete(int user_id)
        {
            var userToDelete = await _context.Users.FindAsync(user_id);
            _context.Users.Remove(userToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Users>> Get()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<Users> GetById(int user_id)
        {
            return await _context.Users.FindAsync(user_id);
        }

        public async Task Update(PutUser putUser)
        {
            string username = putUser.Name;
            string[] nameParts = username.Split(' ');
            string firstName = nameParts.LastOrDefault() ?? "";
            string lastName = string.Join(" ", nameParts.Take(nameParts.Length - 1));
            string initials = string.Concat(lastName.Split().Select(Name => Name.Substring(0, 1).ToLower()));
            string userAccount = $"{initials}{firstName}";
            string userOld = userAccount;

            var checkUserName = from n in _context.Users.Where(n => n.username.Equals(userAccount))
                                select n;
            int suffix = 1;
            while (checkUserName.Any(u => u.username == userAccount))
            {
                userAccount = $"{userOld}{suffix}";
                suffix++;
            }
            DateTime currentDate = DateTime.Now;
            var createData = new Users()
            {
                user_id = putUser.user_id,
                Name = putUser.Name,
                username = userAccount,
                address = putUser.address,
                phone_number = putUser.phone_number,
                email = putUser.email,
                access_level = putUser.access_level,
                date_of_birth = putUser.date_of_birth,
                date_update = currentDate,

            };

            _context.Entry(createData).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
  
    }
}
