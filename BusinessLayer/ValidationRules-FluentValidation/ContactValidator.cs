using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_FluentValidation
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
                RuleFor(x=>x.UserMail).NotEmpty().WithMessage("Mail adresini boş geçmeyiniz.");
                RuleFor(x=>x.UserName).NotEmpty().WithMessage("Kullanıcı adını boş geçmeyiniz.");
                RuleFor(x=>x.Message).NotEmpty().WithMessage("Mesaj alanını boş geçmeyiniz.");
                RuleFor(x=>x.Subject).MinimumLength(5).WithMessage("Konu alanına en az 5 karakter giriniz.");
                RuleFor(x=>x.Subject).MaximumLength(50).WithMessage("Konu alanına en fazla 50 karakter giriniz.");
        }
    }
}
