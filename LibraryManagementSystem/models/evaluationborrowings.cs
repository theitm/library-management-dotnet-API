using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models
{
    public class evaluationborrowings
    {
        [Key]
        public int evaluation_id { get; set; }
        public evaluation? evaluation { get; set; }

        public int borrowings_id { get; set; }
        public borrowings? borrowings { get; set; }
    }
}
