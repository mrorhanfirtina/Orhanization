using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.OrderControllers;

public class OrderAttributeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] OrderAttributesDetailLevel detailLevel)
    {
        GetByCodeOrderAttributeQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeOrderAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] OrderAttributesDetailLevel detailLevel)
    {
        GetByIdOrderAttributeQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdOrderAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListOrderAttributeQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListOrderAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] OrderAttributeDynamicModel? dynamicModel = null)
    {
        GetListByDynamicOrderAttributeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicOrderAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
