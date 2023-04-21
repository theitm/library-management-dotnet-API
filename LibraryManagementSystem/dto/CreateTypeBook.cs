using LibraryManagementSystem.models.Entity;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.dto
{
    public class CreateTypeBook
    {
        [Key]
        public int Type_ID { get; set; }
        public string Type { get; set; }
        public DateTime Date_created { get; set; }
        public DateTime Date_updated { get; set; }
    }
}
