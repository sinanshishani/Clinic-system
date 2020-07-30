using System.ComponentModel.DataAnnotations;

namespace EClinic.Framework.Security
{
    public class TokenRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}