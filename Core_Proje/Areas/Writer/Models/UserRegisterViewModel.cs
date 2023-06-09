﻿using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lutfen Adinizi Girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lutfen Soyadinizi Girin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lutfen Resim URL'i Girin")]
        public string ImagURL { get; set; }

        [Required(ErrorMessage ="Lutfen Kullanici Adinizi Girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lutfen Bir Sifre Girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lutfen Sifrenizi Tekrar Girin")]
        [Compare("Password", ErrorMessage ="Sifreler Uyumlu Degil!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lutfen Mail Adresinizi Girin")]
        public string Mail { get; set; }
    }
}
