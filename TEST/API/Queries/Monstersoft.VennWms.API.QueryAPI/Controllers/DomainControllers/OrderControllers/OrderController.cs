using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants;
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
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] OrdersDetailLevel detailLevel)
    {
        GetByCodeOrderQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeOrderResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] OrdersDetailLevel detailLevel)
    {
        GetByIdOrderQuery query = new() { Id = id, DetailLevel = detailLevel };

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
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] OrderDynamicModel? dynamicModel = null)
    {
        GetListByDynamicOrderQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicOrderListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
