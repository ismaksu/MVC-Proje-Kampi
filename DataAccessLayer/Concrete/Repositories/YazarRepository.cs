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
    public class YazarRepository : IYazarDAL
    {
        Context c = new Context();
        DbSet<Yazar> _object;

        public Yazar Bul(Expression<Func<Yazar, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Ekle(Yazar p)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Yazar p)
        {
            throw new NotImplementedException();
        }

        public List<Yazar> Listele()
        {
            throw new NotImplementedException();
        }

        public List<Yazar> Listele(Expression<Func<Yazar, bool>> filtre)
        {
            throw new NotImplementedException();
        }

        public void Sil(Yazar p)
        {
            throw new NotImplementedException();
        }
    }
}
