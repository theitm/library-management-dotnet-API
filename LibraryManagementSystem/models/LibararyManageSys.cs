using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//public enum access_level
//{
//    admin,
//    user,
//    member,
//}
namespace LibraryManageSys.models
{
    public class LibraryManageSys
    {
        public class Users

        {
            [Key]
            public int userID { get; set; }
            public string? Name { get; set; }

            public string? username { get; set; }
            public string? password { get; set; }
            public string? address { get; set; }
            public string? phone_number { get; set; }
            public string? email { get; set; }
            public string? access_level { get; set; }
            public string? date_of_birth { get; set; }
            public string? date_created { get; set; }
            public string? date_update { get; set; }
            public ICollection<Returnings>? returnings { get; set; }
            public ICollection<Borrowings>? borrowings { get; set; }
            public IList<RatingUsers>? ratingusers { get; set; }
        }
        public class Books
        {
            [Key]
            public int bookID { get; set; }
            public string? title { get; set; }

            public string? author { get; set; }
            public string? publisher { get; set; }
            public string? publication { get; set; }
            public int? quantity { get; set; }
            public string? type_book { get; set; }
            public string? date_created { get; set; }
            public string? date_update { get; set; }
            public ICollection<Borrowings>? borrowings { get; set; }
            public IList<BooksRating>? booksrating { get; set; }
            public IList<BooksUsers>? booksusers { get; set; }
        }
        public class Rating
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ratingID { get; set; }
            [ForeignKey("userID")]
            public int userID { get; set; }
            [ForeignKey("bookID")]
            public int bookID { get; set; }
            [ForeignKey("borrowingID")]
            public int borrowingID { get; set; }
            public string? rate { get; set; }
            public string? comment_rate { get; set; }
            public string? time_rate { get; set; }
            public IList<BooksRating>? booksratings { get; set; }
            public IList<RatingUsers>? ratingusers { get; set; }

        }
        public class Returnings
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int returningID { get; set; }
            [ForeignKey("borrowingID")]
            public int borrowingID { get; set; }
            [ForeignKey("userID")]
            public int userID { get; set; }
            public string? returning_date { get; set; }
            public string? quantity { get; set; }
            public string? lost_book { get; set; }
            public string? date_created { get; set; }
            public string? date_update { get; set; }

            public Users? users { get; set; }
            public Borrowings? borrowings { get; set; }
        }
        public class Borrowings
        {

            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int borrowingID { get; set; }
            [ForeignKey("userID")]
            public int userID { get; set; }
            [ForeignKey("bookID")]
            public int bookID { get; set; }
            public string? borrowings_date { get; set; }
            public string? due_date { get; set; }
            public string? quantity { get; set; }
            public string? date_created { get; set; }
            public string? date_update { get; set; }

            public Books? books { get; set; }
            public Users? users { get; set; }

            public ICollection<Returnings>? returnings { get; set; }

        }
        public class Document
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int documentID { get; set; }
            public int parentID { get; set; }
            public int parent_type { get; set; }
            public int url { get; set; }
            public int type_url { get; set; }

        }
        public class BooksRating
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int bookID { get; set; }
            public Books? books { get; set; }

            public int ratingID { get; set; }
            public Rating? rating { get; set; }
        }
        public class BooksUsers
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int bookID { get; set; }
            public Books? books { get; set; }

            public int usersID { get; set; }
            public Users? users { get; set; }
        }
        public class RatingUsers
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ratingID { get; set; }
            public Rating? rating { get; set; }

            public int usersID { get; set; }
            public Users? users { get; set; }
        }
        public class RatingBorrowings
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ratingID { get; set; }
            public Rating? rating { get; set; }

            public int borrowingsID { get; set; }
            public Borrowings? borrowings { get; set; }
        }


    }
}