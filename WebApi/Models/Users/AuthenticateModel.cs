using System.ComponentModel.DataAnnotations;

namespace FoolCardGame.API.Models.Users
{
    public class AuthenticateModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}