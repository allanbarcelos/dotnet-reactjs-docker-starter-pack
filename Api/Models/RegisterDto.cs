using Microsoft.AspNetCore.Identity;

namespace Api.Models
    {
        public class RegisterDto
        {
            public string? Name { get; set; }
            public string? Photo { get; set; }
            public string? PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
        }
        
    }
