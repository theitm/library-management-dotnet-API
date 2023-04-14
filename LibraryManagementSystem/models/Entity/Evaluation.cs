using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.models.Entity
{
    public class Evaluation
    {
        [Key]
        public int Evaluation_ID { get; set; }
        [ForeignKey("User_ID")]
        public int User_ID { get; set; }
        [ForeignKey("Book_ID")]
        public int Book_ID { get; set; }
        [ForeignKey("Borrowing_ID")]
        public int Borrowing_ID { get; set; }
        public string? Rate { get; set; }
        public string? Comment_rate { get; set; }
        public DateTime Time_rate { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
    }
}
