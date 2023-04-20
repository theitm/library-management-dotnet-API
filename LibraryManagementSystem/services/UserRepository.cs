using LibraryManagementSystem.Context;
using LibraryManagementSystem.dto;
using LibraryManagementSystem.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using LibraryManagementSystem.models.Entity;


namespace LibraryManagementSystem.services
{
    public class UserRepository : IUserRepository
    {
        private readonly LibraryManagementSystemDbContext _context;
        public UserRepository(LibraryManagementSystemDbContext context)
        {
            _context = context;
        }
        public async Task<IQueryable<User>> GetSearchUser(string Name)
        {
            var allDataUser = _context.Set<User>().AsNoTracking();

            if (Name != null)
            {
                allDataUser = allDataUser.Where(x => x.Name.Contains(Name));
            }
            return allDataUser;
        }
    }
}

