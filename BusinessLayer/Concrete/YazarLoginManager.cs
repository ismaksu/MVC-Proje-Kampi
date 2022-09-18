using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class YazarLoginManager : IYazarLoginService
    {
        IYazarDAL _yazarDal;

        public YazarLoginManager(IYazarDAL yazarDal)
        {
            _yazarDal = yazarDal;
        }

        public Yazar YazarCek(string uName, string pWord)
        {
            return _yazarDal.Bul(x => x.YazarMail == uName && pWord == x.YazarSifre);
        }
    }
}
