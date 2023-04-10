﻿using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.dto
{
    public class UserDTO
    {
        public int user_id { get; set; }
        public string? Name { get; set; }
        public string? username { get; set; }
        public string? address { get; set; }
        [RegularExpression("(84|0[3|5|7|8|9])+([0-9]{8})", ErrorMessage = "incorrectly entered")]
        public string? phone_number { get; set; }
        [RegularExpression("^[\\w.+\\-]+@gmail\\.com$", ErrorMessage = "incorrectly entered")]
        public string? email { get; set; }
        public int? access_level { get; set; }
        [RegularExpression("^(0[1-9]|1[012])[-/.](0[1-9]|[12][0-9]|3[01])[-/.](19|20)\\d\\d$", ErrorMessage = "incorrectly entered")]
        public string? date_of_birth { get; set; }
        //[RegularExpression("^(0[1-9]|1[012])[-/.](0[1-9]|[12][0-9]|3[01])[-/.](19|20)\\d\\d$", ErrorMessage = "incorrectly entered")]
        public DateTime date_created { get; set; }
        //[RegularExpression("^(0[1-9]|1[012])[-/.](0[1-9]|[12][0-9]|3[01])[-/.](19|20)\\d\\d$", ErrorMessage = "incorrectly entered")]
        public DateTime date_update { get; set; }
    }
}
