using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.OrderControllers;

public class OrderTypeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] OrderTypesDetailLevel detailLevel)
    {
        GetByCodeOrderTypeQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeOrderTypeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] OrderTypesDetailLevel detailLevel)
    {
        GetByIdOrderTypeQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdOrderTypeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] OrderTypesDetailLevel detailLevel)
    {
        GetListOrderTypeQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListOrderTypeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] OrderTypeDynamicModel? dynamicModel = null)
    {
        GetListByDynamicOrderTypeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicOrderTypeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
