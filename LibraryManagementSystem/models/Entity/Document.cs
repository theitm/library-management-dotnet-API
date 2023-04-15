using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models.Entity
{
    public class Document
    {
        [Key]
        public int Document_ID { get; set; }
        public int Parent_ID { get; set; }
        public int Parent_type { get; set; }
        public int URL { get; set; }
        public int Type_URL { get; set; }
    }
}
