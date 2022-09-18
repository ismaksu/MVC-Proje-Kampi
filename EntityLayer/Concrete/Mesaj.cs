using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Mesaj
    {
        [Key]
        public int MesajID { get; set; }

        [StringLength(50)]
        public string GonderenMail { get; set; }

        [StringLength(50)]
        public string AliciMail { get; set; }

        [StringLength(100)]
        public string Konu { get; set; }

        public string MesajIcerik { get; set; }

        public bool MesajOkunmasi { get; set; }

        public DateTime MesajTarih { get; set; }
    }
}
