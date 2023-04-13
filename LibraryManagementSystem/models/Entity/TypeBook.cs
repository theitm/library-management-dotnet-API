namespace LibraryManagementSystem.models.Entity
{
    public class TypeBook
    {
        public int Book_ID { get; set; }
        public string Type { get; set; }
        public DateOnly Date_created { get; set; }
        public DateOnly Date_updated { get; set; }
        public ICollection<Book> Books { get; set;}
    }
}
