using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DomainCore.Models
{
    public class ProductDTO
    {
        [Key]
        public Guid Id { get; set; }
        public BrandDTO Brand { get; set; }
        public CategoryDTO Category { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "В названии бренда должно быть от 4 до 50 символов")]
        public string BrandName { get; set; }
        [Required]
        //[RegularExpression([0-9]\.[0-9]+)]
        [StringLength(11, MinimumLength = 9, ErrorMessage = "В данном поле должно быть от 10 до 11 символов")]
        public string Size { get; set; }
        [Required]
        [StringLength(5, MinimumLength=4, ErrorMessage = "Сезон должен стостоять от 4 до 5 символов")]
        public string Season { get; set; }
        [Required]
        [ProductDTO]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Год должен содержать 4 символа")]
        public int Year { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "Цена не может меньше быть меньше 1")]
        public string Price { get; set; }
        [Required]
        public bool Availability { get; set; }
        [Required]
        [Range(0,5, ErrorMessage = "Рейтинг должен быть от 0 до 5")]
        public int Raiting { get; set; }
        public int year;
        public void Method()
        {
            try
            {
                Add(6);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Catch в Metod: (ex.Message)");
            }
            finally
            {
                Console.WriteLine("Блок finally в Metod: (ex.Message)");
            }
        }
        public void Add(int val)
        {
            try
            {
                int res = val / 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception Divide by zero");
            }
            finally
            {
                Console.WriteLine("Блок finally в Add");
            }
        }
    }
}
