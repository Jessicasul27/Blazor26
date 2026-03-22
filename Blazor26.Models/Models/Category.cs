using System.ComponentModel.DataAnnotations;

namespace Blazor26.Models.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public List<Product>? Products { get; set; }
    }
}
