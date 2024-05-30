using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.StockControllers;

public class StockReserveReasonController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] StockReserveReasonsDetailLevel detailLevel)
    {
        GetByIdStockReserveReasonQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdStockReserveReasonResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] StockReserveReasonDynamicModel? dynamicModel = null)
    {
        GetListByDynamicStockReserveReasonQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicStockReserveReasonListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
