using System.ComponentModel.DataAnnotations;
using LibraryManagementSystem.models;

namespace LibraryManagementSystem.models
{
    public class users
    {
        [Key]
        public int user_id { get; set; }
        public string? Name { get; set; }

        public string? username { get; set; }
        public string? password { get; set; }
        public string? address { get; set; }
        public string? phone_number { get; set; }
        public string? email { get; set; }
        public string? access_level { get; set; }
        public string? date_of_birth { get; set; }
        public string? date_created { get; set; }
        public string? date_update { get; set; }
        public ICollection<returnings>? returnings { get; set; }
        public ICollection<borrowings>? borrowings { get; set; }
        public IList<evaluationusers>? evaluationusers { get; set; }
    }
}
