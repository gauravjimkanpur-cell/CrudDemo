using System.ComponentModel.DataAnnotations;

namespace CrudDemo.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(1000)]
        public string? Description { get; set; }

        [Range(0, 999999.99)]
        public decimal Price { get; set; }
    }
}
