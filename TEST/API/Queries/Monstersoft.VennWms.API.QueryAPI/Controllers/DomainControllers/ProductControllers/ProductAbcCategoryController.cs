using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ProductControllers;

public class ProductAbcCategoryController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ProductAbcCategoriesDetailLevel detailLevel)
    {
        GetByIdProductAbcCategoryQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdProductAbcCategoryResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ProductAbcCategoryDynamicModel? dynamicModel = null)
    {
        GetListByDynamicProductAbcCategoryQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicProductAbcCategoryListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}





