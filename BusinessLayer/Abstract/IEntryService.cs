using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IEntryService
    {
        List<Entry> EntryListele();
        List<Entry> EntryListele(string p);
        List<Entry> YazaraGoreListele(int id);
        List<Entry> Basliktakiler(int id); 
        Entry IDdenBul(int id);
        void EntryEkle(Entry p);
        void EntrySil(Entry p);
        void EntryGuncelle(Entry p);
    }
}
