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
    public class ResimDosyaManager : IResimDosyaService
    {
        IResimDosyaDAL _resimDosyaDAL;

        public ResimDosyaManager(IResimDosyaDAL resimDosyaDal)
        {
            _resimDosyaDAL = resimDosyaDal;
        }

        public List<ResimDosya> ResimListele()
        {
            return _resimDosyaDAL.Listele();
        }
    }
}
