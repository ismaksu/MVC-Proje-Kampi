using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class YazarManager : IYazarService
    { 
        IYazarDAL _yazarDal;

        public YazarManager(IYazarDAL yazarDal)
        {
            _yazarDal = yazarDal;
        }

        public Yazar IDdenBul(int id)
        {
            return _yazarDal.Bul(x => x.YazarID == id);
        }

        public void YazarEkle(Yazar yazar)
        {
            _yazarDal.Ekle(yazar);
        }

        public void YazarGuncelle(Yazar yazar)
        {
            _yazarDal.Guncelle(yazar);
        }

        public List<Yazar> YazarListele()
        {
            return _yazarDal.Listele();
        }

        public bool YazarLoginAuthentication(Yazar yazar)
        {
            var yazarDeger = _yazarDal.Listele(x => x.YazarMail == yazar.YazarMail && x.YazarSifre == yazar.YazarSifre).FirstOrDefault();
            return yazarDeger != null ? true : false;
        }

        public void YazarSil(Yazar yazar)
        {
            _yazarDal.Sil(yazar);
        }
    }
}
