using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.OrderControllers;

public class OrderController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeOrderQuery query = new() { Code = code };

        GetByCodeOrderResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdOrderQuery query = new() { Id = id };

        GetByIdOrderResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListOrderQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListOrderListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicOrderQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicOrderListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
