using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForLoginDto
    {
        [Required]
        [StringLength(15, MinimumLength=4, ErrorMessage="Username length must be between 4 and 15 characters long")]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage="Password length must be between 4 and 8 characters long")]
        public string Password { get; set; }
    }
}