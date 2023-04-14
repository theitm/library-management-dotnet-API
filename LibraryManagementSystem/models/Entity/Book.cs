using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models.Entity
{
    public class Book
    {
        [Key]
        public int Book_ID { get; set; }
        public int Type_ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Publication_date { get; set; }
        public string Quantity { get; set; }
        public DateTime Date_created { get; set; }
        public DateTime Date_updated { get; set; }
        public TypeBook TypeBook { get; set; }
        public ICollection<Evaluation> Evaluations { get; set; }
        public ICollection<Borrowing> Borrowings { get; set; }
    }
}
