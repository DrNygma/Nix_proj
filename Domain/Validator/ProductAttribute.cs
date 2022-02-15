using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DomainCore.Models;


namespace DomainCore.Validator
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
