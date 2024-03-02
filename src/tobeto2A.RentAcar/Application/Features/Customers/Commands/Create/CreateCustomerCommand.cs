using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Commands.Rules;
using Application.Features.Customers.Commands.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customers.Commands.Create;
public class CreateCustomerCommand : IRequest<CreatedCustomerResponse>
{
    public Guid UserId { get; set; }

    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CreatedCustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        private readonly CustomerBusinessRules _customerBusinessRules;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper, CustomerBusinessRules customerBusinessRules)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            _customerBusinessRules = customerBusinessRules;
        }

        public async Task<CreatedCustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
           // await _customerBusinessRules.CouldNotExistsWithSameName(request.Name);

            Customer customer = _mapper.Map<Customer>(request);

            Customer addedCustomer = await _customerRepository.AddAsync(customer);

            CreatedCustomerResponse createdCustomerResponse = _mapper.Map<CreatedCustomerResponse>(addedCustomer);

            return createdCustomerResponse;
        }
    }
}
