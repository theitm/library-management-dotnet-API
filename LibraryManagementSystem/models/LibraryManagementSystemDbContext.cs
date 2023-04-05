using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using static LibraryManagementSystem.models.LibraryManagementSystem;

namespace LibraryManagementSystem.models
{
    public class LibraryManagementSystemDbContext : DbContext
    {
        public LibraryManagementSystemDbContext(DbContextOptions options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<borrowings>()
                .HasOne<users>(b => b.users)
                .WithMany(u => u.borrowings)
                .HasForeignKey(b => b.user_id);
            modelBuilder.Entity<returnings>()
                .HasOne<borrowings>(r => r.borrowings)
                .WithMany(b => b.returnings)
                .HasForeignKey(r => r.borrowing_id);
            modelBuilder.Entity<returnings>()
                .HasOne<users>(r => r.users)
                .WithMany(u => u.returnings);
            //.HasForeignKey(r => r.user_id);
            modelBuilder.Entity<borrowings>()
                .HasOne<books>(b => b.books)
                .WithMany(u => u.borrowings)
                .HasForeignKey(r => r.book_id);
            modelBuilder.Entity<booksevaluation>().HasKey(sc => new { sc.book_id, sc.evaluation_id });
            modelBuilder.Entity<booksusers>().HasKey(sc => new { sc.book_id, sc.users_id });
            modelBuilder.Entity<evaluationusers>().HasKey(sc => new { sc.evaluation_id, sc.users_id });
            modelBuilder.Entity<evaluationborrowings>().HasKey(sc => new { sc.evaluation_id, sc.borrowings_id });
        }

        public DbSet<users> users { get; set; }
        public DbSet<books> books { get; set; }
        public DbSet<evaluation> evaluations { get; set; }
        public DbSet<returnings> returnings { get; set; }
        public DbSet<borrowings> borrowings { get; set; }
        public DbSet<document> documents { get; set; }

        public DbSet<booksevaluation> booksevaluations { get; set; }
        public DbSet<booksusers> booksusers { get; set; }
        public DbSet<evaluationusers> evaluationusers { get; set; }
        public DbSet<evaluationborrowings> evaluationborrowings { get; set; }

    }
}