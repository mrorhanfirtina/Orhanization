using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ProductControllers;

public class ItemUnitController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ItemUnitsDetailLevel detailLevel)
    {
        GetByIdItemUnitQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdItemUnitResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ItemUnitDynamicModel? dynamicModel = null)
    {
        GetListByDynamicItemUnitQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicItemUnitListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
