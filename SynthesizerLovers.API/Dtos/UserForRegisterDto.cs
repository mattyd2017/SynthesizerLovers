using System.ComponentModel.DataAnnotations;

namespace SynthesizerLovers.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "your password must be between 4 and 8 characters in length")]
        public string Password { get; set; }

    }
}