using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IYazarService
    {
        List<Yazar> YazarListele();

        void YazarEkle(Yazar yazar);

        void YazarSil(Yazar yazar);

        void YazarGuncelle(Yazar yazar);

        Yazar IDdenBul(int id);

        bool YazarLoginAuthentication(Yazar yazar);
    }
}
