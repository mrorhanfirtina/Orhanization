using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LocationControllers;

public class ZoneController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] ZonesDetailLevel detailLevel)
    {
        GetByCodeZoneQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeZoneResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ZonesDetailLevel detailLevel)
    {
        GetByIdZoneQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdZoneResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] ZonesDetailLevel detailLevel)
    {
        GetListZoneQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListZoneListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ZoneDynamicModel? dynamicModel = null)
    {
        GetListByDynamicZoneQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicZoneListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
