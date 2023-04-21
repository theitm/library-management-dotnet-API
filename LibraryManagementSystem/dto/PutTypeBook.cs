using LibraryManagementSystem.models.Entity;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.dto
{
    public class PutTypeBook
    {
        public int Type_ID { get; set; }
        public string Type { get; set; }
        public DateTime Date_updated { get; set; }
    }
}
