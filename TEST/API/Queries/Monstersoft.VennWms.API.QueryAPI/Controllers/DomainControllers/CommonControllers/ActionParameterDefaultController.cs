using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Constants;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.CommonControllers;

public class ActionParameterDefaultController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ActionParameterDefaultsDetailLevel detailLevel)
    {
        GetByIdActionParameterDefaultQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdActionParameterDefaultResponse result = await Mediator.Send(query);

        return Ok(result);
    }


    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ActionParameterDefaultDynamicModel? dynamicModel = null)
    {
        GetListByDynamicActionParameterDefaultQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicActionParameterDefaultListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}

