using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yazar
    {
        [Key]
        public int YazarID { get; set; }

        [StringLength(50)]
        public string YazarAd { get; set; }

        [StringLength(300)]
        public string YazarResim { get; set; }

        [StringLength(175)]
        public string YazarAciklama { get; set; }

        [StringLength(400)] //Şifreleneceği için boyutu büyük tuttuk. (Şifre de aynı şekilde)
        public string YazarMail { get; set; }

        [StringLength(400)]
        public string YazarSifre { get; set; }

        [StringLength(75)]
        public string YazarUnvan { get; set; }

        public bool YazarDurum { get; set; }

        //------------------İlişkiler----------------------

        public ICollection<Baslik> Basliks { get; set; }

        public ICollection<Entry> Entries { get; set; }
    }
}