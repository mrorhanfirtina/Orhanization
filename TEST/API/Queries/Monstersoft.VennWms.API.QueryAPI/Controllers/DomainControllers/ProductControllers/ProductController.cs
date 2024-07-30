using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ProductControllers;

public class ProductController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] ProductsDetailLevel detailLevel)
    {
        GetByCodeProductQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeProductResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ProductsDetailLevel detailLevel)
    {
        GetByIdProductQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdProductResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListProductQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListProductListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ProductDynamicModel? dynamicModel = null)
    {
        GetListByDynamicProductQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicProductListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }
}