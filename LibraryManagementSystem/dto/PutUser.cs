namespace LibraryManagementSystem.dto
{
    public class PutUser
    {
        internal int id;

        public int User_ID { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Address { get; set; }
        public string? Phone_number { get; set; }
        public string? Email { get; set; }
        public string? Access_level { get; set; }
        public string? Date_of_birth { get; set; }
        public string? Date_udate { get; set; }
    }
}
