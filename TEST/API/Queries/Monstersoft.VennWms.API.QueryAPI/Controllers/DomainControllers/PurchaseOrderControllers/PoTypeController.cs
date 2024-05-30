using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.PurchaseOrderDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.PurchaseOrderControllers;

public class PoTypeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] PoTypesDetailLevel detailLevel)
    {
        GetByCodePoTypeQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodePoTypeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] PoTypesDetailLevel detailLevel)
    {
        GetByIdPoTypeQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdPoTypeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] PoTypesDetailLevel detailLevel)
    {
        GetListPoTypeQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListPoTypeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] PoTypeDynamicModel? dynamicModel = null)
    {
        GetListByDynamicPoTypeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicPoTypeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
