using Application.Features.IndividualCustomers.Commands.Create;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models.Commands.Create;
public class CreateModelCommandValidator : AbstractValidator<CreateModelCommand>
{
    public CreateModelCommandValidator()
    {
        RuleFor(i => i.Name).NotEmpty().NotNull().MinimumLength(2);
        RuleFor(i => i.Year).NotEmpty().NotNull().InclusiveBetween((short)1900, (short)DateTime.Now.Year);

    }
}
