using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.PurchaseOrderDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.PurchaseOrderControllers;

public class PoAttributeValueController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] PoAttributeValuesDetailLevel detailLevel)
    {
        GetByIdPoAttributeValueQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdPoAttributeValueResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] PoAttributeValueDynamicModel? dynamicModel = null)
    {
        GetListByDynamicPoAttributeValueQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicPoAttributeValueListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
