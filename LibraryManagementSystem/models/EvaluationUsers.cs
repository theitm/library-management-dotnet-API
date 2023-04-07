using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models
{
    public class EvaluationUsers
    {
        [Key]
        public int evaluation_id { get; set; }
        public Evaluation? Evaluation { get; set; }

        public int users_id { get; set; }
        public Users? Users { get; set; }
    }
}
