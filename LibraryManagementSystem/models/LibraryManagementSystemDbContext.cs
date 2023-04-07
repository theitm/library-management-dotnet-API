
using LibraryManagementSystem.dto;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using LibraryManagementSystem.models;

namespace LibraryManagementSystem.models
{
    public class LibraryManagementSystemDbContext : DbContext
    {

        public LibraryManagementSystemDbContext(DbContextOptions options) : base(options)
        { } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<User>().
            //    HasKey(x => new { x.user_id });
            modelBuilder.Entity<Users>().
                HasKey(x => new { x.user_id });
            modelBuilder.Entity<Books>().
                HasKey(x => new { x.book_id });
            modelBuilder.Entity<Evaluation>().
                HasKey(x => new { x.evaluation_id/*, x.user_id, x.borrowing_id, x.book_id*/ });
            modelBuilder.Entity<Returnings>().
                HasKey(x => new { x.returning_id/*, x.user_id ,x.borrowing_id, */});
            modelBuilder.Entity<Borrowings>().
                HasKey(x => new { x.borrowing_id/*, x.book_id, x.user_id */});
            modelBuilder.Entity<Document>().
                HasKey(x => new { x.document_id });

            modelBuilder.Entity<Borrowings>()
                .HasOne<Users>(b => b.Users)
                .WithMany(u => u.Borrowings)
                .HasForeignKey(b => b.user_id);

            modelBuilder.Entity<Returnings>()
                .HasOne<Borrowings>(r => r.Borrowings)
                .WithMany(b => b.Returnings)
                .HasForeignKey(r => r.borrowing_id).
                OnDelete(DeleteBehavior.NoAction);
            //modelBuilder.Entity<returnings>()
            //    .HasOne<users>(r => r.users)
            //    .WithMany(u => u.returnings)
                //.HasForeignKey(r => r.user_id).
                /*OnDelete(DeleteBehavior.NoAction)*/

            modelBuilder.Entity<Borrowings>()
                .HasOne<Books>(b => b.Books)
                .WithMany(u => u.Borrowings)
                .HasForeignKey(r => r.book_id);
            modelBuilder.Entity<BooksEvaluation>().HasKey(sc => new { sc.book_id, sc.evaluation_id });
            modelBuilder.Entity<BooksUsers>().HasKey(sc => new { sc.book_id, sc.users_id });
            modelBuilder.Entity<EvaluationUsers>().HasKey(sc => new { sc.evaluation_id, sc.users_id });
            modelBuilder.Entity<EvaluationBorrowings>().HasKey(sc => new { sc.evaluation_id, sc.borrowings_id });
        
        }


        public DbSet<Users> Users { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Returnings> Returnings { get; set; }
        public DbSet<Borrowings> Borrowings { get; set; }
        public DbSet<Document> Documents { get; set; }
        //public DbSet<User> User { get; set; }

        public DbSet<BooksEvaluation> BooksEvaluations { get; set; }
        public DbSet<BooksUsers> BooksUsers { get; set; }
        public DbSet<EvaluationUsers> EvaluationUsers { get; set; }
        public DbSet<EvaluationBorrowings> EvaluationBorrowings { get; set; }
        
    }
}
