using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nix_proj.Models.Products;
using System.ComponentModel.DataAnnotations;

namespace Nix_proj.Models.Categories
{
    class Category
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "В названии категории должно быть от 4 до 50 символов")]
        public string Name { get; set; }
        [Required]
        //
        public List<Product> Items { get; set; }

    }
}
