using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace LibraryManagementSystem.models 
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}
