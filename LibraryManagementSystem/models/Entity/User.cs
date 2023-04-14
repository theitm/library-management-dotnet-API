using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.models.Entity
{
    public class User
    {
        [Key]
        public int User_ID { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public string? Phone_number { get; set; }
        public string? Email { get; set; }
        public string? Access_level { get; set; }
        public string? Date_of_birth { get; set; }
        public DateTime Date_created { get; set; }
        public DateTime Date_update { get; set; }
        public ICollection<Borrowing>? Borrowings { get; set; }
        public ICollection<Evaluation>? Evaluations { get; set; }
    }
}
