using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models
{
    public class booksusers
    {

        [Key]
        public int book_id { get; set; }
        public books? books { get; set; }

        public int users_id { get; set; }
        public users? users { get; set; }
    }
}
