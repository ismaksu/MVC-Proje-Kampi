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
    public class HakkindaManager : IHakkindaService
    {
        IHakkindaDAL _hakkindaDal;

        public HakkindaManager(IHakkindaDAL hakkindaDal)
        {
            _hakkindaDal = hakkindaDal;
        }

        public void HakkindaEkle(Hakkinda hakkinda)
        {
            _hakkindaDal.Ekle(hakkinda);
        }

        public void HakkindaGuncelle(Hakkinda hakkinda)
        {
            _hakkindaDal.Guncelle(hakkinda);
        }

        public List<Hakkinda> HakkindaListele()
        {
            return _hakkindaDal.Listele();
        }

        public void HakkindaSil(Hakkinda hakkinda)
        {
            _hakkindaDal.Sil(hakkinda);
        }

        public Hakkinda IDdenBul(int id)
        {
            return _hakkindaDal.Bul(x => x.HakkindaID == id);
        }
    }
}
