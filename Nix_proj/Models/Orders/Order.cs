using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Nix_proj.Models.Products;

namespace Nix_proj.Models.Orders
{
    class Order
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public virtual List<Product> Products { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string OrderPrice { get; set; }
        [Required]
        [Range (5, 70)]
        public string Sale { get; set; }
    }
}
