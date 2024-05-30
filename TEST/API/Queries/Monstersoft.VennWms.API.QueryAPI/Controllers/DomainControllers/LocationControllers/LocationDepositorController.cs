using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LocationControllers;

public class LocationDepositorController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] LocationDepositorsDetailLevel detailLevel)
    {
        GetByIdLocationDepositorQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdLocationDepositorResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] LocationDepositorDynamicModel? dynamicModel = null)
    {
        GetListByDynamicLocationDepositorQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicLocationDepositorListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}

