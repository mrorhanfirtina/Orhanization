using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Queries.GetListByUserToken;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.CommonControllers;

public class ActionParameterController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id, [FromBody] ActionParameterDetailLevel detailLevel)
    {
        GetByIdActionParameterQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdActionParameterResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ActionParameterDynamicModel? dynamicModel = null)
    {
        GetListByDynamicActionParameterQuery query = new() { PageRequest = pageRequest, DetailLevel = dynamicModel.DetailLevel, DynamicQuery = dynamicModel.DynamicQuery };
        GetListResponse<GetListByDynamicActionParameterListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByUserToken")]
    public async Task<IActionResult> GetListByUserToken([FromQuery] Guid? depositorId = null)
    {
        GetListByUserTokenActionParameterQuery query = new() { DepositorId = depositorId };
        List<GetListByUserTokenActionParameterListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }
}
