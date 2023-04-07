namespace LibraryManagementSystem.dto
{
    public class PutUser
    {
        
        public int user_id { get; set; }
        public string? Name { get; set; }
        public string? username { get; set; }
        public string? address { get; set; }
        public string? phone_number { get; set; }
        public string? email { get; set; }
        public int? access_level { get; set; }
        public string? date_of_birth { get; set; }
        public string? date_created { get; set; }
        public string? date_udate { get; set; }
}
}
