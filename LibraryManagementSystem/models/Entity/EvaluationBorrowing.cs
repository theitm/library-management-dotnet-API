using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models.Entity
{
    public class EvaluationBorrowing
    {
        [Key]
        public int Evaluation_ID { get; set; }
        public Evaluation? Evaluations { get; set; }

        public int Borrowings_ID { get; set; }
        public Borrowing? Borrowings { get; set; }
    }
}
