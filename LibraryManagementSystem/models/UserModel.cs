using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace LibraryManagementSystem.models
{
    public class UserModel
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
    }

}
