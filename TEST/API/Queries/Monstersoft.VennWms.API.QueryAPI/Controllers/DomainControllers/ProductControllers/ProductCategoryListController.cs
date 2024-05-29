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

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ProductControllers;

public class ProductCategoryListController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeProductCategoryListQuery query = new() { Code = code };

        GetByCodeProductCategoryListResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
    {
        GetByIdProductCategoryListQuery query = new() { Id = id };

        GetByIdProductCategoryListResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListProductCategoryListQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListProductCategoryListListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicProductCategoryListQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicProductCategoryListListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}






