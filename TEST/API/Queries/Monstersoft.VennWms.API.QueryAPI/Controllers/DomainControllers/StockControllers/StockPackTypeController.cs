using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.StockControllers;

public class StockPackTypeController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] StockPackTypesDetailLevel detailLevel)
    {
        GetByIdStockPackTypeQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdStockPackTypeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] StockPackTypeDynamicModel? dynamicModel = null)
    {
        GetListByDynamicStockPackTypeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicStockPackTypeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
