using Application.Features.IndividualCustomers.Commands.Create;
using Application.Features.IndividualCustomers.Commands.Rules;
using Application.Features.Models.Commands.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models.Commands.Create;
public class CreateModelCommand : IRequest<CreatedModelResponse>
{
    public Guid BrandId { get; set; } 
    public Guid FuelId { get; set; } 
    public Guid TransmissionId { get; set; } 
    public string Name { get; set; }
    public short Year { get; set; }

    public class CreateModelCommandHandler : IRequestHandler<CreateModelCommand, CreatedModelResponse>
    {
        private readonly IModelRepository _modelRepository;
        private readonly IMapper _mapper;
        private readonly ModelBusinessRules _modelBusinessRules;

        public CreateModelCommandHandler(IModelRepository modelRepository, IMapper mapper, ModelBusinessRules modelBusinessRules)
        {
            _modelRepository = modelRepository;
            _mapper = mapper;
            _modelBusinessRules = modelBusinessRules;
        }

        public async Task<CreatedModelResponse> Handle(CreateModelCommand request, CancellationToken cancellationToken)
        {
            // await _customerBusinessRules.CouldNotExistsWithSameName(request.Name);

            Model model = _mapper.Map<Model>(request);

            Model addedModel = await _modelRepository.AddAsync(model);

            CreatedModelResponse createdModelResponse = _mapper.Map<CreatedModelResponse>(addedModel);

            return createdModelResponse;
        }
    }
}
