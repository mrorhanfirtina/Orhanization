using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LocationControllers;

public class LocationProductAbcCategoryController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] LocationProductAbcCategoriesDetailLevel detailLevel)
    {
        GetByIdLocationProductAbcCategoryQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdLocationProductAbcCategoryResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] LocationProductAbcCategoryDynamicModel? dynamicModel = null)
    {
        GetListByDynamicLocationProductAbcCategoryQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicLocationProductAbcCategoryListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}






