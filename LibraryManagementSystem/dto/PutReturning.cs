namespace LibraryManagementSystem.dto
{
    public class PutReturning
    {
        public DateTime Returning_date { get; set; }
        public int Quantity { get; set; }
        public bool? Lost_book { get; set; }
    }
}
