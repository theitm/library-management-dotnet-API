using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models
{
    public class BooksUsers
    {
        [Key]
        public int book_id { get; set; }
        public Books? Books { get; set; }

        public int users_id { get; set; }
        public Users? Users { get; set; }
    }
}
