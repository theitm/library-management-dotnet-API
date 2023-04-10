using System.ComponentModel.DataAnnotations;
using LibraryManagementSystem.models;

namespace LibraryManagementSystem.models
{
    public enum access_level
    {
        admin,
        user,
        member,
    }
    public class Users

    {
        [Key]
        public int user_id { get; set; }
        public string? Name { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public string? address { get; set; }
        [RegularExpression("(84|0[3|5|7|8|9])+([0-9]{8})", ErrorMessage = "số điện thoại vừa nhập không đúng")]
        public string? phone_number { get; set; }
        [RegularExpression("^[\\w.+\\-]+@gmail\\.com$", ErrorMessage = "gmail sai")]
        public string? email { get; set; }
        public int? access_level { get; set; }
        [RegularExpression("^(0[1-9]|1[012])[-/.](0[1-9]|[12][0-9]|3[01])[-/.](19|20)\\d\\d$", ErrorMessage = "ngày sinh phải có dạng mm/dd/yyy")]
        public string? date_of_birth { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_update { get; set; }
        public ICollection<Returnings>? Returnings { get; set; }
        public ICollection<Borrowings>? Borrowings { get; set; }
        public IList<EvaluationUsers>? EvaluationUsers { get; set; }


    }
}
