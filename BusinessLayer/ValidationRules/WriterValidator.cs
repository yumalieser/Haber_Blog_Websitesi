using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x=>x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı kısmı boş geçilemez !");
            RuleFor(x=>x.WriterName).MinimumLength(2).WithMessage("Lütfen en az karakter sınırına uyan bir isim girin !");
            RuleFor(x=>x.WriterName).MaximumLength(60).WithMessage("Lütfen maximum karakter sınırına uyan bir isim girin !");
            RuleFor(x=>x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez !");
            RuleFor(x=>x.WriterPassword).NotEmpty().WithMessage("Şifre kısmı boş geçilemez !");
        }
    }
}
