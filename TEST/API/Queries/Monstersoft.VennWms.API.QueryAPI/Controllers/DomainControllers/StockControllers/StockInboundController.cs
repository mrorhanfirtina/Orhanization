using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.StockControllers;


public class StockInboundController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] StockInboundsDetailLevel detailLevel)
    {
        GetByIdStockInboundQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdStockInboundResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] StockInboundDynamicModel? dynamicModel = null)
    {
        GetListByDynamicStockInboundQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicStockInboundListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
