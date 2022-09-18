using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hakkinda
    {
        [Key]
        public int HakkindaID { get; set; }

        [StringLength(1000)]
        public string HakkindaCont1 { get; set; }

        [StringLength(1000)]
        public string HakkindaCont2 { get; set; }

        [StringLength(175)]
        public string HakkindaResim1 { get; set; }

        [StringLength(175)]
        public string HakkindaResim2 { get; set; }
    }
}
