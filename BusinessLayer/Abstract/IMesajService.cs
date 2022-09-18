using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMesajService
    {
        List<Mesaj> InboxListele(string p);
        List<Mesaj> SendboxListele(string p);
        void MesajEkle(Mesaj p);
        void MesajSil(Mesaj p);
        void MesajGuncelle(Mesaj p);
        Mesaj IDdenBul(int id);
    }
}
