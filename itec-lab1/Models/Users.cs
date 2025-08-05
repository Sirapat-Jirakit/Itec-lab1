using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace itec_lab1.Models
{
    [Table("users")]
    public class Users
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        [Required]
        [EmailAddress]
        [MaxLength(256)]
        public string Email { get; set; } = default!;

        [Required]
        [MaxLength(512)]
        public string Password { get; set; } = default!;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public bool IsActive { get; set; } = true;
    }
}
