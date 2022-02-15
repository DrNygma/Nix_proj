using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace DomainCore.Models
{
    public class CartItemDTO
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Количество товара должно быть в пределах от 0 до 100")]
        public int Quantity { get; set; }
    }
}
