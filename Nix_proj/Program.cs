using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nix_proj.Models.User;
using System.ComponentModel.DataAnnotations;

namespace Nix_proj
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2000, 07, 14);
            User user = new User() { Login = "Kek", Password = "qwerasdf", ConfirmPassword = "qwer1234", PhoneNumber = "099-299-80-031", Mail = "fff", Address = "Home", DateOfBirth = date };
            OrderedParallelQuery 
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
        }
    }
}
