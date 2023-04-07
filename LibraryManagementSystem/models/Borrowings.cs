using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.models
{
    public class Borrowings
    {

        [Key]
        public int borrowing_id { get; set; }
        [ForeignKey("user_id")]
        public int user_id { get; set; }
        [ForeignKey("book_id")]
        public int book_id { get; set; }
        public string? borrowings_date { get; set; }
        public string? due_date { get; set; }
        public string? quantity { get; set; }
        public string? date_created { get; set; }
        public string? date_udate { get; set; }
        public Books? Books { get; set; }
        public Users? Users { get; set; }
        public ICollection<Returnings>? Returnings { get; set; }
    }
}
