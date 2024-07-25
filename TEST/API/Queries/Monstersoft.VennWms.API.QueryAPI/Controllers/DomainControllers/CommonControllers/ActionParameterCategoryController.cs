using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.CommonControllers;


public class ActionParameterCategoryController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id, [FromBody] ActionParameterCategoryDetailLevel detailLevel)
    {
        GetByIdActionParameterCategoryQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdActionParameterCategoryResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ActionParameterCategoryDynamicModel? dynamicModel = null)
    {
        GetListByDynamicActionParameterCategoryQuery query = new() { PageRequest = pageRequest, DetailLevel = dynamicModel.DetailLevel, DynamicQuery = dynamicModel.DynamicQuery };
        GetListResponse<GetListByDynamicActionParameterCategoryListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }
}
