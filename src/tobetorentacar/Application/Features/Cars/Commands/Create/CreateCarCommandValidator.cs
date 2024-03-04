using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Commands.Create;

public class CreateCarCommandValidator : AbstractValidator<CreateCarCommand>
{
    public CreateCarCommandValidator()
    {
        RuleFor(c => c.Model).NotEmpty().MinimumLength(2);
        RuleFor(c => c.Brand).NotEmpty();
        RuleFor(c => c.Year).NotEmpty().GreaterThan(1900); 
        RuleFor(c => c.Color).NotEmpty();
    }
}