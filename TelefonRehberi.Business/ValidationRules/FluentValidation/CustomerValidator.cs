using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Title).NotEmpty().WithMessage("Ünvan boş olamaz");
            RuleFor(c => c.Title).MaximumLength(100);
            RuleFor(c => c.Name).MaximumLength(50);
            RuleFor(c => c.LastName).MaximumLength(50);
            RuleFor(c => c.Phone1).MaximumLength(50);
            RuleFor(c => c.Phone2).MaximumLength(50);
        }
    }
}
