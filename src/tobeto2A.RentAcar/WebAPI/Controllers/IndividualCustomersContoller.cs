using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Queries.GetList;
using Application.Features.Customers.Commands.Create;
using Application.Features.Customers.Queries.GetList;
using Application.Features.Fuels.Commands.Create;
using Application.Features.Fuels.Queries.GetList;
using Application.Features.IndividualCustomers.Commands.Create;
using Application.Features.IndividualCustomers.Queries.GetList;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class IndividualCustomersController : BaseController
{
    [HttpPost]

    public async Task<IActionResult> Add([FromBody] CreateIndividualCustomerCommand command)
    {
        CreatedIndividualCustomerResponse response = await Mediator.Send(command);

        return Created("", response);
    }

    [HttpGet]

    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        GetListIndividualCustomerQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListIndividualCustomerItemDto> response = await Mediator.Send(query);

        return Ok(response);
    }
}

