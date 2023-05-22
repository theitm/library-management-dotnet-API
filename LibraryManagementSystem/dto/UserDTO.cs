using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.dto
{
    public class UserDTO
    {
        public int User_id { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Address { get; set; }
        [RegularExpression("(84|0[3|5|7|8|9])+([0-9]{8})", ErrorMessage = "incorrectly entered")]
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
