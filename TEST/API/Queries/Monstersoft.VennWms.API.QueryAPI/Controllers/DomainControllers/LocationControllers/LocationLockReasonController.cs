using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LocationControllers;

public class LocationLockReasonController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] LocationLockReasonsDetailLevel detailLevel)
    {
        GetByIdLocationLockReasonQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdLocationLockReasonResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] LocationLockReasonDynamicModel? dynamicModel = null)
    {
        GetListByDynamicLocationLockReasonQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicLocationLockReasonListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}

