using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.OrderControllers;

public class OrderItemMemoController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] OrderItemMemosDetailLevel detailLevel)
    {
        GetByIdOrderItemMemoQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdOrderItemMemoResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] OrderItemMemoDynamicModel? dynamicModel = null)
    {
        GetListByDynamicOrderItemMemoQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicOrderItemMemoListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
