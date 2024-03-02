using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CorporateCustomers.Commands.Rules;
public class CorporateCustomerBusinessRules : BaseBusinessRules
{
    private readonly ICorporateCustomerRepository _corporateCustomerRepository;

    public CorporateCustomerBusinessRules(ICorporateCustomerRepository corporateCustomerRepository)
    {
        _corporateCustomerRepository = corporateCustomerRepository;
    }

    public async Task ThereCannotBeCompanyWiththeSameCompanyName(string companyName)
    {
        CorporateCustomer? corporateCustomerWithSameName = await _corporateCustomerRepository.GetAsync(c => c.CompanyName == companyName);

        if (corporateCustomerWithSameName is not null)
            throw new BusinessException("Aynı isme sahip bir şirket zaten mevcut.");
    }
}
