using LibraryManagementSystem.models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static LibraryManagementSystem.models.users;

namespace LibraryManagementSystem.models
{
    public class returnings
    {
        [Key]
        public int returning_id { get; set; }
        [ForeignKey("borrowing_id")]
        public int borrowing_id { get; set; }
        //[ForeignKey("user_id")]
        //public int user_id { get; set; }
        public string? returning_date { get; set; }
        public string? quantity { get; set; }
        public string? lost_book { get; set; }
        public string? date_created { get; set; }
        public string? date_update { get; set; }

        public int Currentborrowings_id;
        public int Currentuser_id;
        public users? users { get; set; }
        public borrowings? borrowings { get; set; }
    }
}
