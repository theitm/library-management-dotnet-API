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
        public TimeOnly Time_rate { get; set; }
        public IList<BookEvaluation>? BooksEvaluations { get; set; }
        public IList<EvaluationUser>? EvaluationUsers { get; set; }
    }
}
