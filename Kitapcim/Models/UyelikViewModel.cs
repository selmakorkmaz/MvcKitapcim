using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kitapcim.Models
{
    public class Kullanici
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string Ad { get; set; }
    }
    public class KullaniciSifre : Kullanici
    {
        [Required]
        [Display(Name = "Şifre")]
        public string Sifre { get; set; }

        [Required]
        [Display(Name = "Şifreyi Tekrar Yazınız")]
        public string Sifre2 { get; set; }
    }
    public class KullaniciSifreDegistir : Kullanici
    {
        [Required]
        [Display(Name = "Eski Şifre")]
        public string EskiSifre { get; set; }

        [Required]
        [Display(Name = "Yeni Şifre")]
        public string YeniSifre { get; set; }

        [Required]
        [Display(Name = "Yeni Şifreyi Yeniden Yazınız")]
        public string YeniSifre2 { get; set; }
    }
    public class KullaniciSifreTanimla : Kullanici
    {
        [Required]
        [Display(Name = "Yeni Şifre")]
        public string YeniSifre { get; set; }

        [Required]
        [Display(Name = "Yeni Şifreyi Yeniden Yazınız")]
        public string YeniSifre2 { get; set; }
    }

    public class Rol
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Rol Adı")]
        public string Ad { get; set; }
    }

    public class KullaniciGiris
    {
        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string Ad { get; set; }

        [Required]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }

    }
}