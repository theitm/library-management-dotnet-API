using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.models
{
    public class borrowings
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
        public string? date_update { get; set; }
        public int Currentuser_id;
        public int Currentbook_id;

        public books? books { get; set; }
        public users? users { get; set; }
        public ICollection<returnings>? returnings { get; set; }
    }
}
