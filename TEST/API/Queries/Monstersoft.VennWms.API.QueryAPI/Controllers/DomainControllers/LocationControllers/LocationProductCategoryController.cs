using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LocationControllers;

public class LocationProductCategoryController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] LocationProductCategoriesDetailLevel detailLevel)
    {
        GetByIdLocationProductCategoryQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdLocationProductCategoryResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] LocationProductCategoryDynamicModel? dynamicModel = null)
    {
        GetListByDynamicLocationProductCategoryQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicLocationProductCategoryListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}






