using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class KategoriValidator:AbstractValidator<Kategori>
    {
        public KategoriValidator()
        {
            RuleFor(x => x.KategoriAd).NotEmpty().WithMessage("Kategori adını boş bırakamazsınız!");
            RuleFor(x => x.KategoriAciklama).NotEmpty().WithMessage("Açıklama kısmını boş bırakamazsınız!");
            RuleFor(x => x.KategoriAd).MinimumLength(3).WithMessage("Kategori ismi 3 karakterden az olmamalıdır.");
            RuleFor(x => x.KategoriAd).MaximumLength(20).WithMessage("Kategori ismi 20 karakterden fazla olmamalıdır.");
        }
    }
}
