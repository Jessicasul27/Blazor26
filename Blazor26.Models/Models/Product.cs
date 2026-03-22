using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor26.Models.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage="Please enter Name")]
        public string Name { get; set; } = string.Empty;

        public string? Image { get; set; }
        public float Price { get; set; }
        public string? description { get; set; }

        // Foreign Key (one-to-many relationship)
        [Range(1, 300, ErrorMessage ="Please enter number between 1 and 300")]
        public int CategoryID { get; set; }

        public Category? Category { get; set; }
 
    }

}
