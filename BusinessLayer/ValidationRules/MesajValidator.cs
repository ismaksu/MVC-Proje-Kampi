using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class MesajValidator: AbstractValidator<Mesaj>
    {
        public MesajValidator()
        {
            RuleFor(x => x.AliciMail).NotEmpty().WithMessage("Alıcı adresini boş geçemezsiniz!");
            RuleFor(x => x.Konu).NotEmpty().WithMessage("Konuyu boş geçemezsiniz!");
            RuleFor(x => x.MesajIcerik).NotEmpty().WithMessage("Mesajınız boş olamaz!");
            RuleFor(x => x.Konu).MinimumLength(3).WithMessage("Lütfen konu başlığınız en az 3 karakter olsun.");
            RuleFor(x => x.MesajIcerik).MinimumLength(3).WithMessage("Lütfen mesajınız en az 3 karakter olsun.");
            RuleFor(x => x.Konu).MaximumLength(50).WithMessage("Konu başlığı 50 karakteri geçemez!");
        }
    }
}
