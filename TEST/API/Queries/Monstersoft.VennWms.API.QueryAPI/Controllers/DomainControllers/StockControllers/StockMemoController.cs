using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.StockControllers;

public class StockMemoController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdStockMemoQuery query = new() { Id = id };

        GetByIdStockMemoResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicStockMemoQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicStockMemoListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
