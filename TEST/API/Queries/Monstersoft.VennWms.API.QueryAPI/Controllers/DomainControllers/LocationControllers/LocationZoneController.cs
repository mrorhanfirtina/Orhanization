using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LocationControllers;

public class LocationZoneController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] LocationZonesDetailLevel detailLevel)
    {
        GetByIdLocationZoneQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdLocationZoneResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] LocationZoneDynamicModel? dynamicModel = null)
    {
        GetListByDynamicLocationZoneQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicLocationZoneListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
