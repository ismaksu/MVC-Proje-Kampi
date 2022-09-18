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
    public class MesajManager : IMesajService
    {
        IMesajDAL _mesajDal;

        public MesajManager(IMesajDAL mesajDal)
        {
            _mesajDal = mesajDal;
        }

        public Mesaj IDdenBul(int id)
        {
            return _mesajDal.Bul(x => x.MesajID == id);
        }

        public List<Mesaj> InboxListele(string p)
        {
            return _mesajDal.Listele(x => x.AliciMail == p);
        }

        public void MesajEkle(Mesaj p)
        {
            _mesajDal.Ekle(p);
        }

        public void MesajGuncelle(Mesaj p)
        {
            _mesajDal.Guncelle(p);
        }

        public void MesajSil(Mesaj p)
        {
            _mesajDal.Sil(p);
        }

        public List<Mesaj> SendboxListele(string p)
        {
            return _mesajDal.Listele(x => x.GonderenMail == p);
        }
    }
}
