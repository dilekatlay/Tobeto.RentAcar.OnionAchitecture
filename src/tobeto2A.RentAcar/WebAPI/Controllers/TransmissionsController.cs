using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Queries.GetList;
using Application.Features.Customers.Commands.Create;
using Application.Features.Customers.Queries.GetList;
using Application.Features.Fuels.Commands.Create;
using Application.Features.Fuels.Queries.GetList;
using Application.Features.IndividualCustomers.Commands.Create;
using Application.Features.IndividualCustomers.Queries.GetList;
using Application.Features.Models.Commands.Create;
using Application.Features.Models.Queries.GetList;
using Application.Features.Transmissions.Commands.Create;
using Application.Features.Transmissions.Queries.GetList;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TransmissionsController : BaseController
{
    [HttpPost]

    public async Task<IActionResult> Add([FromBody] CreateTransmissionCommand command)
    {
        CreatedTransmissionResponse response = await Mediator.Send(command);

        return Created("", response);
    }

    [HttpGet]

    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        GetListTransmissionQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListTransmissionItemDto> response = await Mediator.Send(query);

        return Ok(response);
    }
}

