
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models

{
    public class BooksEvaluation
    {
        [Key]
        public int book_id { get; set; }
        public Books? Books { get; set; }

        public int evaluation_id { get; set; }
        public Evaluation? Evaluation { get; set; }
    }
}
