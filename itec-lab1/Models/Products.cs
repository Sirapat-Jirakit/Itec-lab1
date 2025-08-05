using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace itec_lab1.Models
{
    [Table("products")]
    public class Products
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string ProductName { get; set; } = default!;

        public Categories Category { get; init; }

        [Required]
        public int SellPrice { get; set; } = default!;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public bool IsActive { get; set; } = true;

        [Column("ProductCreatedBy")]
        public int ProductCreatedBy { get; set; }

        [Column("ProductUpdatedBy")]
        public int ProductUpdatedBy { get; set; }

        public Officers CreatedBy { get; set; }

        public Officers UpdatedBy { get; set; }
    }
}
