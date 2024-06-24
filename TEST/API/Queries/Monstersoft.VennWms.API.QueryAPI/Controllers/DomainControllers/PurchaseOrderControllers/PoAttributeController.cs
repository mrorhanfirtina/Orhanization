using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.PurchaseOrderDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.PurchaseOrderControllers;

public class PoAttributeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] PoAttributesDetailLevel detailLevel)
    {
        GetByCodePoAttributeQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodePoAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] PoAttributesDetailLevel detailLevel)
    {
        GetByIdPoAttributeQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdPoAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] PoAttributesDetailLevel detailLevel)
    {
        GetListPoAttributeQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListPoAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] PoAttributeDynamicModel? dynamicModel = null)
    {
        GetListByDynamicPoAttributeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicPoAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
