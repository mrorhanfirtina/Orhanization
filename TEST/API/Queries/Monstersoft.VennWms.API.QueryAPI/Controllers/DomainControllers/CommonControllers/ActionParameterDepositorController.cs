using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.CommonControllers;

public class ActionParameterDepositorController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ActionParameterDepositorDetailLevel detailLevel)
    {
        GetByIdActionParameterDepositorQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdActionParameterDepositorResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ActionParameterDepositorDynamicModel? dynamicModel = null)
    {
        GetListByDynamicActionParameterDepositorQuery query = new() { PageRequest = pageRequest, DetailLevel = dynamicModel.DetailLevel, DynamicQuery = dynamicModel.DynamicQuery };
        GetListResponse<GetListByDynamicActionParameterDepositorListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }
}
