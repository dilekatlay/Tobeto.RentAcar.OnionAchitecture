using Application.Features.Fuels.Commands.Create;
using Application.Features.Fuels.Queries.GetList;
using Application.Features.IndividualCustomers.Commands.Create;
using Application.Features.IndividualCustomers.Queries.GetList;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.IndividualCustomers.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<IndividualCustomer, CreateIndividualCustomerCommand>().ReverseMap();
        CreateMap<IndividualCustomer, CreatedIndividualCustomerResponse>().ReverseMap();
        CreateMap<IndividualCustomer, GetListIndividualCustomerItemDto>().ReverseMap();
        CreateMap<IPaginate<IndividualCustomer>, GetListResponse<GetListIndividualCustomerItemDto>>().ReverseMap();
    }
}
