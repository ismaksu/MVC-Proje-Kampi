using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IKategoriDAL:IRepository<Kategori>
    {
        //Create Read Update Remove
        //Listing
        List<Kategori> Listele();

        //Inserting
        void Ekle(Kategori p);

        //Updating
        void Guncelle(Kategori p);

        //Removing
        void Sil(Kategori p);
    }
}
