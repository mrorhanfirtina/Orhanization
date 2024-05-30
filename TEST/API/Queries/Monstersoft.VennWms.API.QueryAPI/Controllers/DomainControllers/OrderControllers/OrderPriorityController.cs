using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.OrderControllers;

public class OrderPriorityController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] OrderPrioritiesDetailLevel detailLevel)
    {
        GetByIdOrderPriorityQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdOrderPriorityResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] OrderPriorityDynamicModel? dynamicModel = null)
    {
        GetListByDynamicOrderPriorityQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicOrderPriorityListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}






