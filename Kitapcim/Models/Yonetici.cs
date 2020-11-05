using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kitapcim.Models
{
    public class Yonetici
    {
        public int ID { get; set; }

        public string kitap_adi { get; set; }

        public string yazar_adi { get; set; }
        public string tur { get; set; }
        [Display(Name = "Basım Tarihi")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime basim_tarihi { get; set; }

        public double fiyat { get; set; }

        public class YoneticiDBContext:DbContext
        {
            public DbSet<Yonetici> kitap { get; set; }
        
        }
    }
}

//En son browse.cshtml foreach sorunu 