using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class KategoriRepository : IKategoriDAL
    {
        Context c = new Context();
        public DbSet<Kategori> _object;

        public void Ekle(Kategori p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public void Guncelle(Kategori p)
        {
            c.SaveChanges();
        }

        public List<Kategori> Listele()
        {
            return _object.ToList();
        }

        public void Sil(Kategori p)
        {
            _object.Remove(p);
        }

        public List<Kategori> Listele(Expression<Func<Kategori, bool>> filtre)
        {
            throw new NotImplementedException();
        }

        public Kategori Bul(Expression<Func<Kategori, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
