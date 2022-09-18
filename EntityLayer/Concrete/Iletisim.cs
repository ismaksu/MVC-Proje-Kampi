﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Iletisim
    {
        [Key]
        public int IletisimID { get; set; }

        [StringLength(50)]
        public string KullaniciAd { get; set; }

        [StringLength(50)]
        public string KullaniciMail { get; set; }

        [StringLength(50)]
        public string Konu { get; set; }

        [StringLength(1500)]
        public string Mesaj { get; set; }

        public DateTime IletisimTarih { get; set; }
    }
}
