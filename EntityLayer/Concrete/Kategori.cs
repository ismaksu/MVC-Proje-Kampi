using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        
        [StringLength(50)]
        public string KategoriAd { get; set; }

        [StringLength(200)]
        public string KategoriAciklama { get; set; }

        public bool CategoryStats { get; set; }

        //------------------İlişkiler----------------------

        public ICollection<Baslik> Basliks { get; set; }
    }
}
