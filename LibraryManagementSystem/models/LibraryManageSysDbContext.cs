using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using static LibraryManageSys.models.LibraryManageSys;

namespace LibraryManageSys.models
{
    public class LibraryManageSysDbContext : DbContext
    {
        public LibraryManageSysDbContext(DbContextOptions options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Borrowings>()
                .HasOne<Users>(b => b.users)
                .WithMany(u => u.borrowings)
                .HasForeignKey(b => b.userID);
            modelBuilder.Entity<Returnings>()
                .HasOne<Borrowings>(r => r.borrowings)
                .WithMany(b => b.returnings)
                .HasForeignKey(r => r.borrowingID);
            modelBuilder.Entity<Returnings>()
                .HasOne<Users>(r => r.users)
                .WithMany(u => u.returnings);
            //.HasForeignKey(r => r.userID);
            modelBuilder.Entity<Borrowings>()
                .HasOne<Books>(b => b.books)
                .WithMany(u => u.borrowings)
                .HasForeignKey(r => r.bookID);
            modelBuilder.Entity<BooksRating>().HasKey(sc => new { sc.bookID, sc.ratingID });
            modelBuilder.Entity<BooksUsers>().HasKey(sc => new { sc.bookID, sc.usersID });
            modelBuilder.Entity<RatingUsers>().HasKey(sc => new { sc.ratingID, sc.usersID });
            modelBuilder.Entity<RatingBorrowings>().HasKey(sc => new { sc.ratingID, sc.borrowingsID });
        }

        public DbSet<Users> users { get; set; }
        public DbSet<Books> books { get; set; }
        public DbSet<Rating> ratings { get; set; }
        public DbSet<Returnings> returnings { get; set; }
        public DbSet<Borrowings> borrowings { get; set; }
        public DbSet<Document> documents { get; set; }

        public DbSet<BooksRating> booksratings { get; set; }
        public DbSet<BooksUsers> booksusers { get; set; }
        public DbSet<RatingUsers> ratingusers { get; set; }
        public DbSet<RatingBorrowings> ratingborrowings { get; set; }

    }
}