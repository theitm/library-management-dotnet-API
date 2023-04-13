using static System.Reflection.Metadata.BlobBuilder;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models.Entity
{
    public class BookEvaluation
    {
        [Key]
        public int Book_ID { get; set; }
        public Book? Books { get; set; }

        public int Evaluation_ID { get; set; }
        public Evaluation? Evaluations { get; set; }
    }
}
