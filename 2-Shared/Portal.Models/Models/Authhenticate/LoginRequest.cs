using System.ComponentModel.DataAnnotations;

namespace Portal.Model
{
    public class LoginRequest
    {
        [Required]
        public string userName { get; set; } = string.Empty;
        [Required]
        public string userPassword { get; set; } = string.Empty;
    }
}
