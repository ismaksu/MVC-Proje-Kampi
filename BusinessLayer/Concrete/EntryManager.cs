using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EntryManager : IEntryService
    {
        IEntryDAL _entryDal;

        public EntryManager(IEntryDAL entryDal)
        {
            _entryDal = entryDal;
        }
        public void EntryEkle(Entry p)
        {
            _entryDal.Ekle(p);
        }

        public void EntryGuncelle(Entry p)
        {
            _entryDal.Guncelle(p);
        }

        public List<Entry> Basliktakiler(int id)
        {
            return _entryDal.Listele(x => x.BaslikID == id);
        }

        public List<Entry> EntryListele()
        {
            return _entryDal.Listele();
        }

        public void EntrySil(Entry p)
        {
            _entryDal.Sil(p);
        }

        public Entry IDdenBul(int id)
        {
            return _entryDal.Bul(x => x.EntryID == id);
        }

        public List<Entry> YazaraGoreListele(int id)
        {
            return _entryDal.Listele(x => x.YazarID == id);
        }

        public List<Entry> EntryListele(string p)
        {
            return !string.IsNullOrEmpty(p) ? _entryDal.Listele(x => x.EntryCont.Contains(p)) : _entryDal.Listele();
        }
    }
}
