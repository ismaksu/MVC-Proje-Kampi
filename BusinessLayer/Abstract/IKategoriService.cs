using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IKategoriService
    {
        List<Kategori> KategoriListele();

        void KategoriEkle(Kategori kategori);

        Kategori IDdenBul(int id);

        void KategoriSil(Kategori kategori);

        void KategoriGuncelle(Kategori kategori);
    }
}
