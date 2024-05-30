using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ProductControllers;

public class ProductAttributeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] ProductAttributesDetailLevel detailLevel)
    {
        GetByCodeProductAttributeQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeProductAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ProductAttributesDetailLevel detailLevel)
    {
        GetByIdProductAttributeQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdProductAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] ProductAttributesDetailLevel detailLevel)
    {
        GetListProductAttributeQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListProductAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ProductAttributeDynamicModel? dynamicModel = null)
    {
        GetListByDynamicProductAttributeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicProductAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
