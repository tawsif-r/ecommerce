using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ecommerce.Models
{

    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public required string Name { get; set; }

        [StringLength(1000)]
        public required string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        public int Stock { get; set; }

        [StringLength(500)]
        public required string ImageUrl { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


    }
}