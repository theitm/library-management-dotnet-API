using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.dto
{
    public class CreateUser
    {
        [Key]
        public int User_ID { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public string? Phone_number { get; set; }
        [RegularExpression("^[\\w.+\\-]+@gmail\\.com$", ErrorMessage = "incorrectly entered")]
        public string? Email { get; set; }
        public string? Access_level { get; set; }
        [RegularExpression("^(0[1-9]|1[012])[-/.](0[1-9]|[12][0-9]|3[01])[-/.](19|20)\\d\\d$", ErrorMessage = "incorrectly entered")]
        public string? Date_of_birth { get; set; }
        public DateTime Date_created { get; set; }
        public DateTime Date_update { get; set; }
    }
}
