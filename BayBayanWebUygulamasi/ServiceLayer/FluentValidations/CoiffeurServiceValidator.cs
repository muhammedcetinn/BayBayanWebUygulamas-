using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.FluentValidations
{
    public class CoiffeurServiceValidator : AbstractValidator<CoiffeurService>
    {
        public CoiffeurServiceValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(150)
                .WithName("Hizmet Adı");
        }
    }
}
