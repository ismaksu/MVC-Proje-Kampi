using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Entry
    {
        [Key]
        public int EntryID { get; set; }

        [StringLength(2000)]
        public string EntryCont { get; set; }

        public DateTime EntryTarih { get; set; }

        public bool EntryDurum { get; set; }

        //------------------İlişkiler----------------------

        public int BaslikID { get; set; }
        public virtual Baslik Baslik { get; set; }

        public int? YazarID { get; set; }
        public virtual Yazar Yazar { get; set; }

    }
}
