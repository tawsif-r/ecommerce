using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        public ICollection<Product>? Products { get; set; }

    }
}