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
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Açıklama boş olamaz.")
                .MinimumLength(50).WithMessage("Açıklama en az 50 karakter olmalı.")
                .MaximumLength(1500).WithMessage("Açıklama en fazla 1500 karakter olmalı.");
            RuleFor(x => x.Image)
                .NotEmpty().WithMessage("Resim boş olamaz.");
        }
    }
}



