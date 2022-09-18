using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> Listele();

        void Ekle(T p);

        T Bul(Expression<Func<T, bool>> filter);

        void Guncelle(T p);

        void Sil(T p);

        List<T> Listele(Expression<Func<T, bool>> filtre);
    }
}
