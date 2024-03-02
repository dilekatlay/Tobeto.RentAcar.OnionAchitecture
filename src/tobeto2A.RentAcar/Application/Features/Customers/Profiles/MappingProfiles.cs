using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Queries.GetList;
using Application.Features.Customers.Commands.Create;
using Application.Features.Customers.Queries.GetList;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customers.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
        CreateMap<Customer, CreatedCustomerResponse>().ReverseMap();
        CreateMap<Customer, GetListCustomerItemDto>().ReverseMap();
        CreateMap<IPaginate<Customer>, GetListResponse<GetListCustomerItemDto>>().ReverseMap();
    }
}
