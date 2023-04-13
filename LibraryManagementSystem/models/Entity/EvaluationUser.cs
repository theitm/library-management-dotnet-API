using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models.Entity
{
    public class EvaluationUser
    {
        [Key]
        public int Evaluation_ID { get; set; }
        public Evaluation? Evaluations { get; set; }

        public int User_ID { get; set; }
        public User? Users { get; set; }
    }
}
