using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models
{
    public class booksevaluation
    {
        [Key]
        public int book_id { get; set; }
        public books? books { get; set; }

        public int evaluation_id { get; set; }
        public evaluation? evaluation { get; set; }
    }
}
