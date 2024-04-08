using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
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
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeZoneQuery query = new() { Code = code };

        GetByCodeZoneResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdZoneQuery query = new() { Id = id };

        GetByIdZoneResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListZoneQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListZoneListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicZoneQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicZoneListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
