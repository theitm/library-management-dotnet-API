namespace LibraryManagementSystem.models.Entity
{
    public class BorrowingDetail
    {
        public int ID { get; set; }
        public int Book_ID { get; set; }
        public string Borrowing_ID { get; set; }
        public string Return_status { get; set; }

    }
}
