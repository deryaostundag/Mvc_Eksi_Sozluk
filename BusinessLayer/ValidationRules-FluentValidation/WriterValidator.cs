using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_FluentValidation
{
    public class WriterValidator : AbstractValidator<Writer>
    {
       public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçmeyiniz.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadını boş geçmeyiniz.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını boş geçmeyiniz, yapmayı sevdiğiniz aktivitelerden bahsedebilirsiniz.");
            RuleFor(x => x.WriterJob).MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz");
            RuleFor(x => x.WriterAbout).MinimumLength(10).WithMessage("Lütfen en az 10 karakter giriniz");
            //RuleFor(x => x.WriterAbout).Must(x => x.Contains("A")).WithMessage("Hakkında kısmında en az bir a harfi içermelidir");
        }

    }
}
