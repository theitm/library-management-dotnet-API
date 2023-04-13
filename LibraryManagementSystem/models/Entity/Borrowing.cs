using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.models.Entity
{
    public class Borrowing
    {
        [Key]
        public int Borrowing_Id { get; set; }
        [ForeignKey]
        public int User_ID { get; set; }
        public string Borrowing_date { get; set; }
        public string Due_date { get; set; }
        public string Returning_date { get; set; }
        public DateOnly Date_created { get; set; }
        public DateOnly Date_updated { get;set; }
        public Book Book { get; set; }
        public ICollection<BorrowingDetail> BorrowingDetails { get; set; }
    }
}
