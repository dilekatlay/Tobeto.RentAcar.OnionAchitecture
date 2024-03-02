using Application.Features.CorporateCustomers.Commands.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CorporateCustomers.Commands.Create;
public class CreateCorporateCustomerCommand : IRequest<CreatedCorporateCustomerResponse>
{
    public Guid Id { get; set; }
    public Guid CustomersId { get; set; }
    public string CompanyName { get; set; }
    public int TaxNo { get; set; }

    public class CreateCorporateCustomerCommandHandler : IRequestHandler<CreateCorporateCustomerCommand, CreatedCorporateCustomerResponse>
    {
        private readonly ICorporateCustomerRepository _corporateCustomerRepository;
        private readonly IMapper _mapper;
        private readonly CorporateCustomerBusinessRules _corporateCustomersBusinessRules;

        public CreateCorporateCustomerCommandHandler(ICorporateCustomerRepository corporateCustomerRepository, IMapper mapper, CorporateCustomerBusinessRules corporateCustomersBusinessRules)
        {
            _corporateCustomerRepository = corporateCustomerRepository;
            _mapper = mapper;
            _corporateCustomersBusinessRules = corporateCustomersBusinessRules;
        }

        async Task<CreatedCorporateCustomerResponse> IRequestHandler<CreateCorporateCustomerCommand, CreatedCorporateCustomerResponse>.Handle(CreateCorporateCustomerCommand request, CancellationToken cancellationToken)
        {
            await _corporateCustomersBusinessRules.ThereCannotBeCompanyWiththeSameCompanyName(request.CompanyName);

            CorporateCustomer corporateCustomer = _mapper.Map<CorporateCustomer>(request);

            CorporateCustomer addedCorporateCustomer = await _corporateCustomerRepository.AddAsync(corporateCustomer);

            CreatedCorporateCustomerResponse createdCorporateCustomerResponse = _mapper.Map<CreatedCorporateCustomerResponse>(addedCorporateCustomer);

            return createdCorporateCustomerResponse;
        }
    }
}

