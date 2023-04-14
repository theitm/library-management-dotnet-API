//using Microsoft.EntityFrameworkCore;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

////public enum access_level
////{
////    admin,
////    user,
////    member,
////}
//namespace LibraryManagementSystem.models
//{
//    public class LibraryManagementSystem
//    {
//        //public class users

//        //{
//        //    [Key]
//        //    public int user_id { get; set; }
//        //    public string? Name { get; set; }

//        //    public string? username { get; set; }
//        //    public string? password { get; set; }
//        //    public string? address { get; set; }
//        //    public string? phone_number { get; set; }
//        //    public string? email { get; set; }
//        //    public string? access_level { get; set; }
//        //    public string? date_of_birth { get; set; }
//        //    public string? date_created { get; set; }
//        //    public string? date_update { get; set; }
//        //    public ICollection<returnings>? returnings { get; set; }
//        //    public ICollection<borrowings>? borrowings { get; set; }
//        //    public IList<evaluationusers>? evaluationusers { get; set; }
//        //}
//        public class books
//        {

//            //[Key]  public int book_id { get; set; }
//            //public string? title { get; set; }

//            //public string? author { get; set; }
//            //public string? publisher { get; set; }
//            //public string? publication { get; set; }
//            //public int? quantity { get; set; }
//            //public string? type_book { get; set; }
//            //public string? date_created { get; set; }
//            //public string? date_update { get; set; }
//            //public ICollection<borrowings>? borrowings { get; set; }
//            //public IList<booksevaluation>? booksevaluation { get; set; }
//            //public IList<booksusers>? booksusers { get; set; }
//        }
//        public class evaluation
//        {
//            //[Key]
//            //public int evaluation_id { get; set; }
//            //[ForeignKey("user_id")]
//            //public int user_id { get; set; }
//            //[ForeignKey("book_id")]
//            //public int book_id { get; set; }
//            //[ForeignKey("borrowing_id")]
//            //public int borrowing_id { get; set; }
//            //public string? rate { get; set; }
//            //public string? comment_rate { get; set; }
//            //public string? time_rate { get; set; }
//            //public IList<booksevaluation>? booksevaluations { get; set; }
//            //public IList<evaluationusers>? evaluationusers { get; set; }

//        }
//        public class returnings
//        {
//            //[Key]
//            //public int returning_id { get; set; }
//            //[ForeignKey("borrowing_id")]
//            //public int borrowing_id { get; set; }
//            ////[ForeignKey("user_id")]
//            ////public int user_id { get; set; }
//            //public string? returning_date { get; set; }
//            //public string? quantity { get; set; }
//            //public string? lost_book { get; set; }
//            //public string? date_created { get; set; }
//            //public string? date_update { get; set; }

//            //public int Currentborrowings_id;
//            //public int Currentuser_id;
//            //public users? users { get; set; }
//            //public borrowings? borrowings { get; set; }
//        }
//        public class borrowings
//        {

//            [Key]
//            //public int borrowing_id { get; set; }
//            //[ForeignKey("user_id")]
//            //public int user_id { get; set; }
//            //[ForeignKey("book_id")]
//            //public int book_id { get; set; }
//            //public string? borrowings_date { get; set; }
//            //public string? due_date { get; set; }
//            //public string? quantity { get; set; }
//            //public string? date_created { get; set; }
//            //public string? date_update { get; set; }
//            //public int Currentuser_id;
//            //public int Currentbook_id;

//            //public books? books { get; set; }
//            //public users? users { get; set; }
//            //public ICollection<returnings>? returnings { get; set; }
//        }
//        public class document
//        {
//            //[Key]
//            //public int document_id { get; set; }
//            //public int parent_id { get; set; }
//            //public int parent_type { get; set; }
//            //public int url { get; set; }
//            //public int type_url { get; set; }

//        }
//        public class booksevaluation
//        {
//            //[Key]
//            //public int book_id { get; set; }
//            //public books? books { get; set; }

//            //public int evaluation_id { get; set; }
//            //public evaluation? evaluation { get; set; }
//        }
//        //public class booksusers
//        //{
//        //    [Key]
//        //    public int book_id { get; set; }
//        //    public books? books { get; set; }

//        //    public int users_id { get; set; }
//        //    public users? users { get; set; }
//        }
//        //public class evaluationusers
//        //{
//        //    //[Key]
//        //    //public int evaluation_id { get; set; }
//        //    //public evaluation? evaluation { get; set; }

//        //    //public int users_id { get; set; }
//        //    //public users? users { get; set; }
//        //}
//        //public class evaluationborrowings
//        //{
//        //    [Key]
//        //    public int evaluation_id { get; set; }
//        //    public evaluation? evaluation { get; set; }

//        //    public int borrowings_id { get; set; }
//        //    public borrowings? borrowings { get; set; }
//        //}


//    }
//}
