using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını boş geçemezsiniz");
            RuleFor(x => x.WriterSurName.Contains("a")).NotEmpty().WithMessage("Yazar SoyAdını boş geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda ksımını boş geçemezsiniz");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterSurName).MinimumLength(3).WithMessage("Hakkımda ksımını boş geçemezsiniz");
            RuleFor(x => x.WriterSurName).MaximumLength(20).WithMessage("Lütfen en az 2 karakter girişi yapın");
        }
       
    }
}
