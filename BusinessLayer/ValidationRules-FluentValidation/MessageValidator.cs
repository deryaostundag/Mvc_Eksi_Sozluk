using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_FluentValidation
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.RecieverMail).EmailAddress().WithMessage("Geçerli bir e-mail adresi giriniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanını boş geçmeyiniz.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj alanını boş geçmeyiniz.");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu alanına en az 5 karakter giriniz.");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Konu alanına en fazla 100 karakter giriniz.");
        }
    }
}
