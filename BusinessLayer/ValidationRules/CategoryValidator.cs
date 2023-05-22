using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CAtegoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez !");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklaması boş geçilemez !");
            RuleFor(x => x.CAtegoryName).MaximumLength(25).WithMessage("Kategori adı en fazla 25 karakter olabilir !");
            RuleFor(x => x.CAtegoryName).MinimumLength(3).WithMessage("Kategori adı en az 3 karakter olabilir !");
        }
    }
}
