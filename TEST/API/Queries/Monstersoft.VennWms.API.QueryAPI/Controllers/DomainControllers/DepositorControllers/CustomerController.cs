using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.DepositorControllers;

public class CustomerController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeCustomerQuery query = new() { Code = code };

        GetByCodeCustomerResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdCustomerQuery query = new() { Id = id };

        GetByIdCustomerResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListCustomerQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListCustomerListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicCustomerQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicCustomerListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
