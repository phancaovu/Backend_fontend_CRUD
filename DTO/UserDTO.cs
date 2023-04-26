using System.ComponentModel.DataAnnotations;

namespace Backend.DTO
{
    public class UserDTO
    {
        [Required]
        [MaxLength(100)]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string FullName { get; set; } = string.Empty;
    }

}
