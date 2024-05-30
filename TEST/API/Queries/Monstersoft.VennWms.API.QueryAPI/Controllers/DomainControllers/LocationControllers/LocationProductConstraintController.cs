using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LocationControllers;

public class LocationProductConstraintController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] LocationProductConstraintsDetailLevel detailLevel)
    {
        GetByIdLocationProductConstraintQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdLocationProductConstraintResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] LocationProductConstraintDynamicModel? dynamicModel = null)
    {
        GetListByDynamicLocationProductConstraintQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicLocationProductConstraintListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}

