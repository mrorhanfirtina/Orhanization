using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ProductControllers;

public class ProductAttributeValueController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ProductAttributeValuesDetailLevel detailLevel)
    {
        GetByIdProductAttributeValueQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdProductAttributeValueResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ProductAttributeValueDynamicModel? dynamicModel = null)
    {
        GetListByDynamicProductAttributeValueQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicProductAttributeValueListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
