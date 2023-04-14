using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.models.Entity
{
    public class TypeBook
    {
        [Key]
        public int Type_ID { get; set; }
        [ForeignKey("Book_ID")]
        public int Book_ID { get; set; }
        public string Type { get; set; }
        public DateTime Date_created { get; set; }
        public DateTime Date_updated { get; set; }
        public ICollection<Book> Books { get; set;}
    }
}
