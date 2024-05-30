using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Constants;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ProductControllers;

public class ProductCategoryListController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] ProductCategoryListsDetailLevel detailLevel)
    {
        GetByCodeProductCategoryListQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeProductCategoryListResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id, [FromBody] ProductCategoryListsDetailLevel detailLevel)
    {
        GetByIdProductCategoryListQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdProductCategoryListResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] ProductCategoryListsDetailLevel detailLevel)
    {
        GetListProductCategoryListQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListProductCategoryListListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ProductCategoryListDynamicModel? dynamicModel = null)
    {
        GetListByDynamicProductCategoryListQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicProductCategoryListListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}






