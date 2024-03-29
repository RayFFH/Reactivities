

using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string email { get; set; }
        [Required]
        [EmailAddress]
        public string Password { get; set; }
        [Required]
        [RegularExpression("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$", ErrorMessage = "Password must be complex")]
        public string DisplayName { get; set; }

        public string Username { get; set; }
    }
}