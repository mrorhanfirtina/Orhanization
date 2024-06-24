using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.PurchaseOrderDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Constants;
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
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] PurchaseOrdersDetailLevel detailLevel)
    {
        GetByCodePurchaseOrderQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodePurchaseOrderResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] PurchaseOrdersDetailLevel detailLevel)
    {
        GetByIdPurchaseOrderQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdPurchaseOrderResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] PurchaseOrdersDetailLevel detailLevel)
    {
        GetListPurchaseOrderQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListPurchaseOrderListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] PurchaseOrderDynamicModel? dynamicModel = null)
    {
        GetListByDynamicPurchaseOrderQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicPurchaseOrderListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
