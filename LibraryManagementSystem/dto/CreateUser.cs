using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.dto
{
    public class CreateUser
    {
            [Key]
            public int user_id { get; set; }
            public string? Name { get; set; }  
            public string? username { get; set; }
            public string? password { get; set; }
            public string? address { get; set; }
            public string? phone_number { get; set; }
            [RegularExpression("^[\\w.+\\-]+@gmail\\.com$", ErrorMessage = "incorrectly entered")]
            public string? email { get; set; }
            public int? access_level { get; set; }
            [RegularExpression("^(0[1-9]|1[012])[-/.](0[1-9]|[12][0-9]|3[01])[-/.](19|20)\\d\\d$", ErrorMessage = "incorrectly entered")]
            public string? date_of_birth { get; set; }
            [RegularExpression("^(0[1-9]|1[012])[-/.](0[1-9]|[12][0-9]|3[01])[-/.](19|20)\\d\\d$", ErrorMessage = "incorrectly entered")]
            public string? date_created { get; set; }
            [RegularExpression("^(0[1-9]|1[012])[-/.](0[1-9]|[12][0-9]|3[01])[-/.](19|20)\\d\\d$", ErrorMessage = "incorrectly entered")]
            public string? date_udate { get; set; }
        }
}
