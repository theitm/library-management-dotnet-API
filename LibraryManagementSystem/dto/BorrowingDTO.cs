using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.dto
{
    public class BorrowingDTO
    {
        public int Borrowing_ID { get; set; }
        public int User_ID { get; set; }
        public string Borrowing_date { get; set; }
        public string Due_date { get; set; }
        public string Returning_date { get; set; }
        public DateTime Date_created { get; set; }
        public DateTime Date_updated { get; set; }
    }
}
