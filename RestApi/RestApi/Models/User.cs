using System.ComponentModel.DataAnnotations;

namespace RestApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 150 characters")]
        public string Username { get; set; } = string.Empty;
        
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}