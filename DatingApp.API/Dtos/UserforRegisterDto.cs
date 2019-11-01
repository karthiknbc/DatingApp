using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserforRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must enter 4 to 8 characters")]
        public string Password { get; set; }
    }
}