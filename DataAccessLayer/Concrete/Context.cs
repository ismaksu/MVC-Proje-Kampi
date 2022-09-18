using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        public DbSet<Baslik> Basliks { get; set; }

        public DbSet<Entry> Entries { get; set; }

        public DbSet<Hakkinda> Hakkindas { get; set; }

        public DbSet<Iletisim> Iletisims { get; set; }

        public DbSet<Kategori> Kategoris { get; set; }

        public DbSet<Yazar> Yazars { get; set; }

        public DbSet<Mesaj> Mesajs { get; set; }

        public DbSet<ResimDosya> ResimDosyas { get; set; }

        public DbSet<Admin> Admins { get; set; }
    }
}
