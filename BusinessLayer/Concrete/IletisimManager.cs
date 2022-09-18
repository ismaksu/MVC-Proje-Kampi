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
    public class IletisimManager : IIletisimService
    {
        IContactDAL _iletisimDal;

        public IletisimManager(IContactDAL iletisimDal)
        {
            _iletisimDal = iletisimDal;
        }

        public Iletisim IDdenBul(int id)
        {
            return _iletisimDal.Bul(x => x.IletisimID == id);
        }

        public void IletisimEkle(Iletisim p)
        {
            _iletisimDal.Ekle(p);
        }

        public void IletisimGuncelle(Iletisim p)
        {
            _iletisimDal.Guncelle(p);
        }

        public List<Iletisim> IletisimListele()
        {
            return _iletisimDal.Listele();
        }

        public void IletisimSil(Iletisim p)
        {
            _iletisimDal.Sil(p);
        }
    }
}
