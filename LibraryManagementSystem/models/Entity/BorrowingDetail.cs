using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.models.Entity
{
    public class BorrowingDetail
    {
        [Key]
        public int ID { get; set; }
        public int Borrowing_ID { get; set; }
        public int Book_ID { get; set; }
        public string Return_status { get; set; }
        public Book Book { get; set; }
        public Borrowing Borrowing { get; set; }
        //public ICollection<Returning> Returning { get; set; }
    }
}
