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
    public class BaslikManager : IBaslikService
    {
        IBaslikDAL _baslikDal;

        public BaslikManager(IBaslikDAL baslikDal)
        {
            _baslikDal = baslikDal;
        }

        public void BaslikEkle(Baslik baslik)
        {
            _baslikDal.Ekle(baslik);
        }

        public void BaslikGuncelle(Baslik baslik)
        {
            _baslikDal.Guncelle(baslik);
        }

        public List<Baslik> BaslikListele()
        {
            return _baslikDal.Listele(x => x.BaslikDurum == true);
        }

        

        public void BaslikSil(Baslik baslik)
        {
            //if (baslik.BaslikDurum)
            //    baslik.BaslikDurum = false;
            //else if (!baslik.BaslikDurum)
            //    baslik.BaslikDurum = true;
            _baslikDal.Guncelle(baslik);
        }

        public Baslik IDdenBul(int id)
        {
            return _baslikDal.Bul(x => x.BaslikID == id);
        }

        public List<Baslik> YazaraGoreListele(int id)
        {
            return _baslikDal.Listele(x => x.YazarID == id);
        }
    }
}
