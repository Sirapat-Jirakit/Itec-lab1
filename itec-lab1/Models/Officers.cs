using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace itec_lab1.Models
{
    [Table("officers")]
    public class Officers
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Gender { get; set; } = default!;

        [Required]
        public string Title { get; set; } = default!;

        [Required]
        public string Name { get; set; } = default!;

        [Required]
        public string Surename { get; set; } = default!;

        [Required]
        public string Position { get; set; } = default!;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public bool IsActive { get; set; } = true;

        public ICollection<Categories> CategoryCreatedBy { get; set; } = new List<Categories>();

        public ICollection<Categories> CategoryUpdatedBy { get; set; } = new List<Categories>();

        public ICollection<Products> ProductCreatedBy { get; set; } = new List<Products>();

        public ICollection<Products> ProductUpdatedBy { get; set; } = new List<Products>();
    }
}
