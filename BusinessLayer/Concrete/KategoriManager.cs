using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class KategoriManager : IKategoriService
    {
        IKategoriDAL _kategoriDal;

        public KategoriManager(IKategoriDAL kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

        public Kategori IDdenBul(int id)
        {
            return _kategoriDal.Bul(x => x.KategoriID == id);
        }

        public void KategoriEkle(Kategori kategori)
        {
            _kategoriDal.Ekle(kategori);
        }

        public void KategoriGuncelle(Kategori kategori)
        {
            _kategoriDal.Guncelle(kategori);
        }

        public List<Kategori> KategoriListele()
        {
            return _kategoriDal.Listele();
        }

        public void KategoriSil(Kategori kategori)
        {
            _kategoriDal.Sil(kategori);
        }
    }
}
