using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class YazarValidator:AbstractValidator<Yazar>
    {
        public YazarValidator()
        {
            RuleFor(x => x.YazarAd).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz!");
            RuleFor(x => x.YazarAd).MinimumLength(2).WithMessage("Yazar adınız en az 2 karakterden oluşmalıdır.");
            RuleFor(x => x.YazarAd).MaximumLength(50).WithMessage("Yazar adınız en fazla 50 karakterden oluşabilir.");
            RuleFor(x => x.YazarAciklama).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz!");
            RuleFor(x => x.YazarAciklama).Must(y => y.Contains('a')).WithMessage("Yazar adınızda a harfinin geçmesi gerekli.");
            RuleFor(x => x.YazarUnvan).NotEmpty().WithMessage("Yazar ünvanını boş geçemezsiniz.");
        }
    }
}
