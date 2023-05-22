namespace LibraryManagementSystem.dto
{
    public class ReturningDTO
    {
        public int Returning_ID { get; set; }
        public int Borrowing_ID { get; set; }
        public DateTime Returning_date { get; set; }
        public int Quantity { get; set; }
        public bool? Lost_book { get; set; }
        public DateTime Date_created { get; set; }
        public DateTime Date_updated { get; set; }
    }
}
