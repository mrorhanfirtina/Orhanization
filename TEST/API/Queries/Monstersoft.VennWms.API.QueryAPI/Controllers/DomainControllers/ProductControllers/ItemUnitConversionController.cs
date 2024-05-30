using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ProductControllers;

public class ItemUnitConversionController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ItemUnitConversionsDetailLevel detailLevel)
    {
        GetByIdItemUnitConversionQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdItemUnitConversionResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ItemUnitConversionDynamicModel? dynamicModel = null)
    {
        GetListByDynamicItemUnitConversionQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicItemUnitConversionListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
