using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nix_proj.Models.Products
{
    class Product
    {
        [Key]
        public Guid Id { get; set; }
        public Guid BrandId { get; set; }
        public Guid CategoryId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "В названии бренда должно быть от 4 до 50 символов")]
        public string BrandName { get; set; }
        [Required]
        //[RegularExpression([0-9]\.[0-9]+)]
        [StringLength(11, MinimumLength = 9, ErrorMessage = "В данном поле должно быть от 10 до 11 символов")]
        public string Size { get; set; }
        [Required]
        [StringLength(11, MinimumLength=10, ErrorMessage = "В данном поле должно быть от 10 до 11 символов")]
        public string Season { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "Цена не может меньше быть меньше 1")]
        public string Price { get; set; }
        [Required]
        public bool Availability { get; set; }
        [Required]
        [Range(0,5, ErrorMessage = "Рейтинг должен быть от 0 до 5")]
        public int Raiting { get; set; }
    }
}
