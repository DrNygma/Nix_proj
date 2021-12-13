﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nix_proj.Models.User
{
    class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Укажите имя!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Недопустимая длина имени")]
        [RegularExpression("^[a-zA-Z0-9_]*$", ErrorMessage = "Доступны только числа и буквы в логине")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Введите пароль!")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Недопустимая длина пароля")]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
        [Phone(ErrorMessage = "Некорректный формат данных для мобильного телефона")]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Некорректный формат данных для почты")]
        public string Mail { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        //[RegularExpression("{0:dd/MM/yyyy}", ErrorMessage = "Некорректный ввод даты рождения!")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
    }
}
