namespace LibraryManagementSystem.dto
{
    public class UserDTO
    {
        public int user_id { get; set; }
        public string? name { get; set; }
        public string? password { get; set; }
        public string? address { get; set; }
        public string? phone_number { get; set; }
        public string? email { get; set; }
        public string? access_level { get; set; }
        public DateTime date_of_birth { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }
    }
}
