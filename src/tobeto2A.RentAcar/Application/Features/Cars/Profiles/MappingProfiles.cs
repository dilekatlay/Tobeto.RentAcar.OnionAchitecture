using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Queries.GetList;
using Application.Features.CorporateCustomers.Commands.Create;
using Application.Features.CorporateCustomers.Queries.GetList;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CorporateCustomers.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CorporateCustomer, CreateCorporateCustomerCommand>().ReverseMap();
        CreateMap<CorporateCustomer, CreatedCorporateCustomerResponse>().ReverseMap();
        CreateMap<CorporateCustomer, GetListCorporateCustomerItemDto>().ReverseMap();
        CreateMap<IPaginate<CorporateCustomer>, GetListResponse <GetListCorporateCustomerItemDto>>().ReverseMap(); 
    }
} 
