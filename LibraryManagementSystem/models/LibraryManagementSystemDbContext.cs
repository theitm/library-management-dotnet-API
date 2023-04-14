using LibraryManagementSystem.models.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;

namespace LibraryManagementSystem.Context
{
    public class LibraryManagementSystemDbContext : DbContext
    {
        public LibraryManagementSystemDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evaluation>()
                .HasOne<Book>(s => s.Book)
                .WithMany(g => g.Evaluations)
                .HasForeignKey(s => s.Book_ID);
            modelBuilder.Entity<Borrowing>()
                .HasOne<Book>(s => s.Book)
                .WithMany(g => g.Borrowings)
                .HasForeignKey(s => s.User_ID);
            modelBuilder.Entity<Book>()
                .HasOne<TypeBook>(s => s.TypeBook)
                .WithMany(g => g.Books)
                .HasForeignKey(s => s.Book_ID);
            modelBuilder.Entity<BorrowingDetail>()
                .HasOne<Borrowing>(s => s.Borrowing)
                .WithMany(g => g.BorrowingDetails)
                .HasForeignKey(s => s.Borrowing_ID);
            modelBuilder.Entity<Borrowing>()
                .HasOne<User>(s => s.User)
                .WithMany(g => g.Borrowings)
                .HasForeignKey(s => s.User_ID);
            modelBuilder.Entity<Evaluation>()
                .HasOne<User>(s => s.User)
                .WithMany(g => g.Evaluations)
                .HasForeignKey(s => s.User_ID);
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Borrowing> Borrowing { get; set; }
        public DbSet<BorrowingDetail> BorrowingDetail { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<Evaluation> Evaluation { get; set; }
        public DbSet<TypeBook> TypeBook { get; set; }
        public DbSet<User> User { get; set; }
    }
}