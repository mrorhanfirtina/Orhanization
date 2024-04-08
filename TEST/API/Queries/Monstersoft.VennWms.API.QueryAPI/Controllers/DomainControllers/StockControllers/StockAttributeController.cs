using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.StockControllers;

public class StockAttributeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeStockAttributeQuery query = new() { Code = code };

        GetByCodeStockAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdStockAttributeQuery query = new() { Id = id };

        GetByIdStockAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListStockAttributeQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListStockAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicStockAttributeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicStockAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
