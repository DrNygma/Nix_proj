using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DomainCore.Models
{
    public class BrandDTO
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "В названии бренда должно быть от 4 до 50 символов")]
        public string Name { get; set; }
    }
}
