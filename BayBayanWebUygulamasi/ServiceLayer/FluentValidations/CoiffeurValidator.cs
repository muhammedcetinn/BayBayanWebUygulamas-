using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.FluentValidations
{
    public class CoiffeurValidator : AbstractValidator<Coiffeur>
    {
        public CoiffeurValidator()
        {
            RuleFor(x => x.Gender)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(150)
                .WithName("Cinsiyet");
        }
    }
}
