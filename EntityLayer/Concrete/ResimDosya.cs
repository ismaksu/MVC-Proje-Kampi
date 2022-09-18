using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ResimDosya
    {
        [Key]
        public int ResimID { get; set; }

        [StringLength(100)]
        public string ResimAd { get; set; }

        [StringLength(500)]
        public string ResimKonum { get; set; }
    }
}
