using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LoggingDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LogControllers;

public class LogStockController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] LogStocksDetailLevel detailLevel)
    {
        GetByIdLogStockQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdLogStockResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] LogStockDynamicModel? dynamicModel = null)
    {
        GetListByDynamicLogStockQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicLogStockListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
