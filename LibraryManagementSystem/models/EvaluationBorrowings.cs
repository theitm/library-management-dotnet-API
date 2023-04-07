using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models
{
    public class EvaluationBorrowings
    {
        [Key]
        public int evaluation_id { get; set; }
        public Evaluation? Evaluation { get; set; }

        public int borrowings_id { get; set; }
        public Borrowings? Borrowings { get; set; }
    }
}
