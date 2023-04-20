namespace LibraryManagementSystem.dto
{
    public class CreateBorrowing
    {
        public int User_ID { get; set; }
        public string? Borrowing_date { get; set; }
        public string? Due_date { get; set; }
        public string? Returning_date { get; set; }
        public DateTime Date_created { get; set; }
        public DateTime Date_updated { get; set; }
    }
}
