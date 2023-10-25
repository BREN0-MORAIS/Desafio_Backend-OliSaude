using FluentValidation;
using OliSaude.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliSaude.Service.Validators
{
    public  class CostumerValidator : AbstractValidator<Costumer>
    {
        public CostumerValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Please enter the name.")
                .NotNull().WithMessage("Please enter the name");
        }
    }
}
