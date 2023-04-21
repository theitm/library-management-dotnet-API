using LibraryManagementSystem.models;
using LibraryManagementSystem.models.Entity;
using Microsoft.EntityFrameworkCore;

public class LibraryManagementContext : DbContext
{
    public LibraryManagementContext(DbContextOptions<LibraryManagementContext> options) : base(options)
    {
    }

    public DbSet<Users> Users { get; set; }
}
