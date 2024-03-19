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
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field is a required field");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("ImageUrl field is a required field");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("ImageUrl2 field is a required field");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Price field is a required field");
            RuleFor(x => x. Completion).NotEmpty().WithMessage("Completion field is a required field");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Name field must be minimum 5 characters");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Name field must be maximum 100 characters");

        }
    }
}
