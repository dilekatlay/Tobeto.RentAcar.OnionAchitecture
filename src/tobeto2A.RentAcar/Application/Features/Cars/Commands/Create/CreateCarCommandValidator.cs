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
        RuleFor(i => i.CarState).NotNull().MinimumLength(2);
        RuleFor(i => i.Kilometer).NotNull().GreaterThanOrEqualTo(0).LessThanOrEqualTo(1000000);
        RuleFor(i => i.Plate).NotNull().MaximumLength(7).MinimumLength(7);

    }
}
