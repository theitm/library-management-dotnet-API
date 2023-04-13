using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.models;

namespace LibraryManagementSystem.Data
{
    public class LibraryManagementSystemContext : DbContext
    {
        public LibraryManagementSystemContext (DbContextOptions<LibraryManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryManagementSystem.models.User> User { get; set; } = default!;
    }
}
