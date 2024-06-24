using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.OrderControllers;

public class OrderMemoController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] OrderMemosDetailLevel detailLevel)
    {
        GetByIdOrderMemoQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdOrderMemoResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] OrderMemoDynamicModel? dynamicModel = null)
    {
        GetListByDynamicOrderMemoQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicOrderMemoListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
