
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.models

{
    public class Document
    {
        [Key]
        public int document_id { get; set; }
        public int parent_id { get; set; }
        public int parent_type { get; set; }
        public int url { get; set; }
        public int type_url { get; set; }

    }
}
