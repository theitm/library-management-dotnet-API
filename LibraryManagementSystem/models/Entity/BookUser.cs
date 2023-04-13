using static System.Reflection.Metadata.BlobBuilder;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models.Entity
{
    public class BookUser
    {
        [Key]
        public int Book_ID { get; set; }
        public Book? Books { get; set; }
        public int Users_ID { get; set; }
        public User? Users { get; set; }
    }
}
