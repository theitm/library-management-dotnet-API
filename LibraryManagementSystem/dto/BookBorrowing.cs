
namespace LibraryManagementSystem.dto
{
    public class BookBorrowing
    {                               
        public int userID { get; set; }
        public int bookID { get; set; }
        public string? borrowings_date { get; set; }
        public string? due_date { get; set; }
        public string? quantity { get; set; }
        public string? date_created { get; set; }
        public string? date_update { get; set; }
    }
}
