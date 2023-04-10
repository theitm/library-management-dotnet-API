using LibraryManagementSystem.models;
using System.ComponentModel.DataAnnotations.Schema;
using MessagePack;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace LibraryManagementSystem.models
{
    public class Returnings
    {
        [Key]
        public int returning_id { get; set; }
        [ForeignKey("borrowing_id")]
        public int borrowing_id { get; set; }
        [ForeignKey("user_id")]
        public int user_id { get; set; }
        public string? returning_date { get; set; }
        public string? quantity { get; set; }
        public string? lost_book { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_update { get; set; }

        public int Currentborrowings_id;
        public int Currentuser_id;
        public Users? Users { get; set; }
        public Borrowings? Borrowings { get; set; }
    }
}
