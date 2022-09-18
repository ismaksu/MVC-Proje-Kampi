using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class IletisimValidator: AbstractValidator<Iletisim>
    {
        public IletisimValidator()
        {
            RuleFor(x => x.KullaniciMail).NotEmpty().WithMessage("Mail adresi boş olamaz.");
            RuleFor(x => x.Konu).NotEmpty().WithMessage("Konu adı boş olamaz.");
            RuleFor(x => x.KullaniciAd).NotEmpty().WithMessage("Kullanıcı adı boş olamaz.");
            RuleFor(x => x.KullaniciAd).MinimumLength(3).WithMessage("Kullanıcı adı 4 karakterden az olamaz.");
            RuleFor(x => x.Konu).MinimumLength(3).WithMessage("Konu en az 3 karakter olmak zorunda.");
            RuleFor(x => x.KullaniciMail).NotEmpty().WithMessage("Mail adresi boş olamaz.");
            RuleFor(x => x.Konu).MaximumLength(50).WithMessage("Konu 50 karakterden fazla olamaz.");

        }
    }
}
