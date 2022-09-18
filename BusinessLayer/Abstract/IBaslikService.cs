using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBaslikService
    {
        List<Baslik> BaslikListele();

        List<Baslik> YazaraGoreListele(int id);

        void BaslikEkle(Baslik baslik);

        void BaslikSil(Baslik baslik);

        void BaslikGuncelle(Baslik baslik);

        Baslik IDdenBul(int id);
    }
}
