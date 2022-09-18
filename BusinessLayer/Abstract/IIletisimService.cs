using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IIletisimService
    {
        List<Iletisim> IletisimListele();
        void IletisimEkle(Iletisim p);
        Iletisim IDdenBul(int id);
        void IletisimSil(Iletisim p);
        void IletisimGuncelle(Iletisim p);
    }
}
