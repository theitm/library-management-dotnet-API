using static LibraryManagementSystem.models.LibraryManagementSystem;

namespace LibraryManagementSystem.dto
{
    public class Books
    {
            public int book_id { get; set; }
            public string? title { get; set; }

            public string? author { get; set; }
            public string? publisher { get; set; }
            public string? publication { get; set; }
            public int? quantity { get; set; }
            public string? type_book { get; set; }
            public string? date_created { get; set; }
            public string? date_update { get; set; }
           
        }
    }

