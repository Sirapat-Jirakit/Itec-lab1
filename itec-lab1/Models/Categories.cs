using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace itec_lab1.Models
{
    [Table("categories")]
    public class Categories
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = default!;

        [Required]
        [MaxLength(100)]
        public string Detail { get; set; } = default!;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [Column("CategoryCreatedBy")]
        public int CategoryCreatedBy { get; set; }

        [Column("CategoryUpdatedBy")]
        public int CategoryUpdatedBy { get; set; }

        [ForeignKey(nameof(CategoryCreatedBy))]
        public Officers CreatedBy { get; set; }

        [ForeignKey(nameof(CategoryUpdatedBy))]
        public Officers UpdatedBy { get; set; }
    }
}
