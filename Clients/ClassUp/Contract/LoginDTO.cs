using System.ComponentModel.DataAnnotations;

namespace Call_External_Service.Clients.ClassUp.Contract
{
    public class LoginDTO
    {
        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; } = null!;

        [Required, MinLength(8), MaxLength(100)]
        public string Password { get; set; } = null!;
    }
}
