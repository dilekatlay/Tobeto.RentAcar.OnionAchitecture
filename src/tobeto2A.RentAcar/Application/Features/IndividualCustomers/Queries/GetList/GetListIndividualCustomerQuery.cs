using Application.Features.Fuels.Queries.GetList;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.IndividualCustomers.Queries.GetList;
public class GetListIndividualCustomerQuery : IRequest<GetListResponse<GetListIndividualCustomerItemDto>>
{
    public PageRequest PageRequest { get; set; }

    public class GetListIndividualCustomerQueryHandler : IRequestHandler<GetListIndividualCustomerQuery, GetListResponse<GetListIndividualCustomerItemDto>>
    {
        private readonly IIndividualCustomerRepository _individualCustomerRepository;
        private readonly IMapper _mapper;

        public GetListIndividualCustomerQueryHandler(IIndividualCustomerRepository individualCustomerRepository, IMapper mapper)
        {
            _individualCustomerRepository = individualCustomerRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListIndividualCustomerItemDto>> Handle(GetListIndividualCustomerQuery request, CancellationToken cancellationToken)
        {
            IPaginate<IndividualCustomer> individualCustomers = await _individualCustomerRepository.GetListAsync(index: request.PageRequest.PageIndex, size: request.PageRequest.PageSize);

            GetListResponse<GetListIndividualCustomerItemDto> response = _mapper.Map<GetListResponse<GetListIndividualCustomerItemDto>>(individualCustomers);

            return response;
        }
    }
}
