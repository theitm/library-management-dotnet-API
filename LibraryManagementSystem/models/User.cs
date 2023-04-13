using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models
{
    public enum access_level
    {
        admin,
        user,
        member,
    }
    public class User
    {
    public int user_id { get; set; }
    public string? name { get; set; }
    public string? username { get; set; }
    public string? password { get; set; }
    public string? address { get; set; }

    [RegularExpression("(84|0[3|5|7|8|9])+([0-9]{8})", ErrorMessage = "incorrectly entered")]
    public string? phone_number { get; set; }
    [RegularExpression("^[\\w.+\\-]+@gmail\\.com$", ErrorMessage = "incorrectly entered")]
    public string? email { get; set; }
    public string? access_level { get; set; }
    public DateTime date_of_birth { get; set; }
    public DateTime date_created { get; set; }
    public DateTime date_updated { get; set; }
    }

}
