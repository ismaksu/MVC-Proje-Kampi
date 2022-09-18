using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public T Bul(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Ekle(T p)
        {
            var addedEntity = c.Entry(p);
            addedEntity.State = EntityState.Added;
            
            c.SaveChanges();
        }

        public void Guncelle(T p)
        {
            var updatedEntity = c.Entry(p);
            updatedEntity.State = EntityState.Modified;

            c.SaveChanges();
        }

        public List<T> Listele()
        {
            return _object.ToList();
        }

        public List<T> Listele(Expression<Func<T, bool>> filtre)
        {
            return _object.Where(filtre).ToList();
        }

        public void Sil(T p)
        {
            var silinenEntity = c.Entry(p);
            silinenEntity.State = EntityState.Deleted;

            c.SaveChanges();
        }
    }
}
