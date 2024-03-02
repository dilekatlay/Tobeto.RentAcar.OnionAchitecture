using Application.Features.Fuels.Commands.Create;
using Application.Features.Fuels.Commands.Rules;
using Application.Features.IndividualCustomers.Commands.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.IndividualCustomers.Commands.Create;
public class CreateIndividualCustomerCommand : IRequest<CreatedIndividualCustomerResponse>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }
    public Guid CustomersId { get; set; }

    public class CreateIndividualCustomerCommandHandler : IRequestHandler<CreateIndividualCustomerCommand, CreatedIndividualCustomerResponse>
    {
        private readonly IIndividualCustomerRepository _individualCustomerRepository;
        private readonly IMapper _mapper;
        private readonly IndividualCustomerBusinessRules _individualCustomerBusinessRules;

        public CreateIndividualCustomerCommandHandler(IIndividualCustomerRepository individualCustomerRepository, IMapper mapper, IndividualCustomerBusinessRules individualCustomerBusinessRules)
        {
            _individualCustomerRepository = individualCustomerRepository;
            _mapper = mapper;
            _individualCustomerBusinessRules = individualCustomerBusinessRules;
        }

        public async Task<CreatedIndividualCustomerResponse> Handle(CreateIndividualCustomerCommand request, CancellationToken cancellationToken)
        {
            // await _customerBusinessRules.CouldNotExistsWithSameName(request.Name);

            IndividualCustomer individualCustomer = _mapper.Map<IndividualCustomer>(request);

            IndividualCustomer addedIndividualCustomer = await _individualCustomerRepository.AddAsync(individualCustomer);

            CreatedIndividualCustomerResponse createdIndividualCustomerResponse = _mapper.Map<CreatedIndividualCustomerResponse>(addedIndividualCustomer);

            return createdIndividualCustomerResponse;
        }
    }
}
