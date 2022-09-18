using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCrypto;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDAL _adminDal;

        public AdminManager(IAdminDAL adminDal)
        {
            _adminDal = adminDal;
        }

        public void AdminEkle(Admin admin)
        {
            var crypto = new SimpleCrypto.PBKDF2();

            var encryptedPass = crypto.Compute(admin.AdminSifre);

            admin.AdminSifre = encryptedPass;

            _adminDal.Ekle(admin);
        }

        public void AdminGuncelle(Admin admin)
        {
            _adminDal.Guncelle(admin);
        }

        public List<Admin> AdminListele()
        {
            return _adminDal.Listele();
        }

        public bool AdminLoginAuthentication(Admin admin)
        {
            var deger = _adminDal.Listele(x => x.AdminSifre == admin.AdminSifre && x.AdminAd == admin.AdminAd).FirstOrDefault();
            return deger != null ? true : false;
        }

        public void AdminSil(Admin admin)
        {
            _adminDal.Sil(admin);
        }

        public Admin IDdenBul(int id)
        {
            return _adminDal.Bul(x => x.AdminID == id);
        }
    }
}
