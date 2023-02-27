using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ListValidator : AbstractValidator<List>
    {
        public ListValidator()
        {
            RuleFor(l => l.ListName).NotEmpty().WithMessage("Lütfen Liste adını boş geçmeyiniz.");
            RuleFor(l => l.CreationDate).NotEmpty();
            RuleFor(l => l.CompletionDate).NotEmpty();

        }
    }
}
