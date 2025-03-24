using System.ComponentModel.DataAnnotations;

namespace UserManagementAPI.DTO
{
    public class UserRegisterDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
