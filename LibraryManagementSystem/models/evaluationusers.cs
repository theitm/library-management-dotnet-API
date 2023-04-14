using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models
{
    public class evaluationusers
    {
        [Key]
        public int evaluation_id { get; set; }
        public evaluation? evaluation { get; set; }

        public int users_id { get; set; }
        public users? users { get; set; }
    }
}
