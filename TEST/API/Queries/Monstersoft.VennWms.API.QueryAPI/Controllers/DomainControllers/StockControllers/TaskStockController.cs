using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.StockControllers;

public class TaskStockController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] TaskStocksDetailLevel detailLevel)
    {
        GetByIdTaskStockQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdTaskStockResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] TaskStockDynamicModel? dynamicModel = null)
    {
        GetListByDynamicTaskStockQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicTaskStockListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
