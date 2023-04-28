using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adi bos gecilermez.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Gorsel alani bos gecilmez.");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Gorsel2 alani bos gecilmez.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat alani bos gecilmez.");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Deger alani bos gecilmez.");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Projeadi en az 5 karakterden olusmak zorundadir.");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Projeadi en fazla 100 karakter olabilir.");
        }
    }
}
