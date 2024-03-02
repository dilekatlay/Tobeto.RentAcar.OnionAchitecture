using Application.Features.CorporateCustomers.Commands.Create;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Application.Features.CorporateCustomers.Queries.GetList;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CorporateCutomersController : BaseController
{
    [HttpPost]

    public async Task<IActionResult> Add([FromBody] CreateCorporateCustomerCommand command)
    {
        CreatedCorporateCustomerResponse response = await Mediator.Send(command);

        return Created("", response);
    }

    [HttpGet]

    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        GetListCorporateCustomerQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListCorporateCustomerItemDto> response = await Mediator.Send(query);

        return Ok(response);
    }
}
