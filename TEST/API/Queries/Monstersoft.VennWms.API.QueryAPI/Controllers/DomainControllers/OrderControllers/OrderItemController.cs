using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.OrderControllers;

public class OrderItemController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] OrderItemsDetailLevel detailLevel)
    {
        GetByIdOrderItemQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdOrderItemResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] OrderItemDynamicModel? dynamicModel = null)
    {
        GetListByDynamicOrderItemQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicOrderItemListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
