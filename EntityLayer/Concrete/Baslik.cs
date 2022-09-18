using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Baslik
    {
        [Key]
        public int BaslikID { get; set; }

        [StringLength(50)]
        public string BaslikAd { get; set; }

        public DateTime BaslikTarih { get; set; }

        public bool BaslikDurum { get; set; }

        //------------------İlişkiler----------------------

        public int KategoriID { get; set; }
        public virtual Kategori Kategori { get; set; }

        public int YazarID { get; set; }
        public virtual Yazar Yazar { get; set; }

        public ICollection<Entry> Entries { get; set; }
    }
}
