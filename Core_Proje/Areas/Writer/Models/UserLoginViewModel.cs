using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name = "Kullanici Adi")]
        [Required(ErrorMessage = "Lutfen Kullanici Adinizi Giriniz!")]
        public string Username { get; set; }
        [Display(Name = "Sifre")]
        [Required(ErrorMessage = "Lutfen Sifrenizi Giriniz!")]
        public string Password { get; set; }
    }
}
