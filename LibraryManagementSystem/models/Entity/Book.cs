using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models.Entity
{
    public class Book
    {
        [Key]
        public int Book_ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Publication_date { get; set; }
        public string Quantity { get; set; }
        public DateOnly Date_created { get; set; }
        public DateOnly Date_updated { get; set; }
    }
}
