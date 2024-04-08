using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LocationControllers;

public class LocationController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeLocationQuery query = new() { Code = code };

        GetByCodeLocationResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdLocationQuery query = new() { Id = id };

        GetByIdLocationResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListLocationQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListLocationListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicLocationQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicLocationListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
