using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DomainCore.Models
{
    public class OrderDTO
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
       
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string OrderPrice { get; set; }
        [Required]
        [Range (5, 70)]
        public string Sale { get; set; }
        public virtual UserDTO User { get; set; }
        public virtual List<ProductDTO> Products { get; set; }
    }
}
