using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.models
{
    public class LibraryManagementSystemDbContext : DbContext
    {
        public LibraryManagementSystemDbContext(DbContextOptions<LibraryManagementSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!;
    }
}
