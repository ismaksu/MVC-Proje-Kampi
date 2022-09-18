using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        List<Admin> AdminListele();
        void AdminEkle(Admin admin);
        Admin IDdenBul(int id);

        bool AdminLoginAuthentication(Admin admin);

        void AdminSil(Admin admin);
        void AdminGuncelle(Admin admin);
    }
}
