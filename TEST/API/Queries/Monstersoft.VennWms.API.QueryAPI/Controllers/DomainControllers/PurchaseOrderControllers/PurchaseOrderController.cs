using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.PurchaseOrderControllers;

public class PurchaseOrderController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodePurchaseOrderQuery query = new() { Code = code };

        GetByCodePurchaseOrderResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdPurchaseOrderQuery query = new() { Id = id };

        GetByIdPurchaseOrderResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListPurchaseOrderQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListPurchaseOrderListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicPurchaseOrderQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicPurchaseOrderListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
