using Application.Features.Fuels.Commands.Create;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.IndividualCustomers.Commands.Create;
public class CreateIndividualCustomerCommandValidator : AbstractValidator<CreateIndividualCustomerCommand>
{
    public CreateIndividualCustomerCommandValidator()
    {
        RuleFor(i => i.FirstName).NotEmpty().NotNull().MinimumLength(2);
        RuleFor(i => i.LastName).NotEmpty().NotNull().MinimumLength(2);
        RuleFor(i => i.NationalIdentity).NotEmpty().NotNull().MinimumLength(11).MaximumLength(11);


    }
}
