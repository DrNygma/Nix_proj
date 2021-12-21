using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nix_proj.Models.Users;
using Nix_proj.Models.Orders;
using Nix_proj.Models.Products;
using System.ComponentModel.DataAnnotations;

namespace Nix_proj
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2000, 07, 14);
            User user = new User() { Login = "Kek", Password = "qwerasdf", ConfirmPassword = "qwer1234", PhoneNumber = "099-299-80-031", Mail = "f///ff", Address = "Home", DateOfBirth = date };
            Product product = new Product() {Year=2010}; 
            List<User> users = new List<User>();
            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);
            if((!Validator.TryValidateObject(user, context, results, true))||(!Validator.TryValidateObject(user, context, results, true)))
            {
                foreach(var temp in results)
                {
                    Console.WriteLine(temp.ErrorMessage);
                }
            }
            Console.ReadKey();
            try
            {
                product.Add(222222222);

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Catch Argument в Main");
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine("Catch в Main" + ex1.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.Message);
            }

            finally
            {
                Console.WriteLine("Блок finally в Add");
            }
        }
    }
    public class UserAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            User user = (User)value;
            if (user.DateOfBirth >= Convert.ToDateTime("01/01/1900"))
            {
                return true;
            }
            else
            {
                this.ErrorMessage = "Дата за пределами диапазона.";
                return false;
            }
        }
    }
    public class ProductAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Product product = (Product)value;
            if ((product.Year >= 2020)&&(product.Year <= 2022))
            {
                return true;
            }
            else
            {
                this.ErrorMessage = "Год выпуска за пределами диапазона.";
                return false;
            }
        }
    }
}
