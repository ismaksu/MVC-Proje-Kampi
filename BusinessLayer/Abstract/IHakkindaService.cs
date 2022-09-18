using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHakkindaService
    {
        List<Hakkinda> HakkindaListele();
        void HakkindaEkle(Hakkinda hakkinda);
        void HakkindaSil(Hakkinda hakkinda);
        void HakkindaGuncelle(Hakkinda hakkinda);
        Hakkinda IDdenBul(int id);
    }
}
