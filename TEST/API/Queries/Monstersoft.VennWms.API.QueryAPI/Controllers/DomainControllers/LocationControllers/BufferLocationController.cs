using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LocationControllers;

public class BufferLocationController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] BufferLocationsDetailLevel detailLevel)
    {
        GetByIdBufferLocationQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdBufferLocationResponse result = await Mediator.Send(query);

        return Ok(result);
    }


    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] BufferLocationDynamicModel? dynamicModel = null)
    {
        GetListByDynamicBufferLocationQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicBufferLocationListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}

