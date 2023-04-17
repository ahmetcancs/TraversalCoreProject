using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutTopValidator : AbstractValidator<AboutTop>
    {
        public AboutTopValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description cannot be empty.");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("(Must be a minimum of 50 characters.)");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("(Must be a maximum of 1500 characters.)");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Image cannot be empty.");
        }
    }
}
