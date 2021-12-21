using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Nix_proj.Models.Products;
using Nix_proj.Models.Users;

namespace Nix_proj.Models.Validator
{
    internal class ProductAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            value = value.ToString();
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
}
