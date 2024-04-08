using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LocationControllers;

public class BuildingController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeBuildingQuery query = new() { Code = code };

        GetByCodeBuildingResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdBuildingQuery query = new() { Id = id };

        GetByIdBuildingResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListBuildingQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListBuildingListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicBuildingQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicBuildingListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
