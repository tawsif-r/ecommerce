using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public required string Name { get; set; }
        
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        
        [Required]
        public required string PasswordHash { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public ICollection<Order>? Orders { get; set; }
    }
}