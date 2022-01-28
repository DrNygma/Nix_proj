using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nix_proj.Models.Users;
using Nix_proj.Models.Orders;
using Nix_proj.Models.Products;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.Json;

namespace Nix_proj
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2000, 07, 14);
            User user = new User() { Login = "Kek", Password = "qwerasdf", ConfirmPassword = "qwerasdf", PhoneNumber = "099-299-80-031", Mail = "d.ryzhova@mail.ru", Address = "Home", DateOfBirth = date };
            Product product = new Product() { BrandName = "Baker", Size = "8.25", Year = 2222, Season = "Fall" };
            List<User> users = new List<User>();

            //List<Product> products = new List<Product>();
            //List<string> fileitems = new List<string>();
            //fileitems.Add(user.ToString());
            //fileitems.Add(product.ToString());
            //var results = new List<ValidationResult>();
            //var context = new ValidationContext(user);
            //if ((!Validator.TryValidateObject(user, context, results, true)) || (!Validator.TryValidateObject(user, context, results, true)))
            //{
            //    foreach (var temp in results)
            //    {
            //        Console.WriteLine(temp.ErrorMessage);
            //    }
            //}
            //Console.ReadKey();
            //try
            //{
            //    product.Add(222222222);

            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("Catch Argument в Main");
            //}
            //catch (DivideByZeroException ex1)
            //{
            //    Console.WriteLine("Catch в Main" + ex1.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception:" + ex.Message);
            //}

            //finally
            //{
            //    Console.WriteLine("Блок finally в Add");
            //}


            //using (StreamWriter file = new StreamWriter("C:\\Users\\7K\\Desktop\\Lesson6\\Text2.txt", false, Encoding.UTF8))
            //{
            //    foreach (User u in users.OfType<User>())
            //    {
            //        file.WriteLine("Логин:" + u.Login + "\nПароль:" + u.Password + ":\n$");
            //    }
            //    //foreach (Product p in products.OfType<Product>())
            //    //{
            //    //    file.WriteLine(p.BrandName + ":\n" + p.Size + ":\n" + p.Year + ":\n" + p.Season + "\n $");
            //    //}
            //}
            var option = new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true
            };
            string str = JsonSerializer.Serialize(user, option);
            Console.WriteLine(str);
            User user1 = JsonSerializer.Deserialize<User>(str);
            user1.GetInfo();

        }
    }
    //public class UserAttribute : ValidationAttribute
    //{
    //    public override bool IsValid(object value)
    //    {
    //        User user = (User)value;
    //        if (user.DateOfBirth >= Convert.ToDateTime("01/01/1900"))
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            this.ErrorMessage = "Дата за пределами диапазона.";
    //            return false;
    //        }
    //    }
    //}
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
