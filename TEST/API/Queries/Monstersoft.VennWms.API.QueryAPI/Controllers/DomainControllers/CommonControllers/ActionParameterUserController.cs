using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.CommonControllers;

public class ActionParameterUserController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ActionParameterUserDetailLevel detailLevel)
    {
        GetByIdActionParameterUserQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdActionParameterUserResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ActionParameterUserDynamicModel? dynamicModel = null)
    {
        GetListByDynamicActionParameterUserQuery query = new() { PageRequest = pageRequest, DetailLevel = dynamicModel.DetailLevel, DynamicQuery = dynamicModel.DynamicQuery };
        GetListResponse<GetListByDynamicActionParameterUserListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }
}
