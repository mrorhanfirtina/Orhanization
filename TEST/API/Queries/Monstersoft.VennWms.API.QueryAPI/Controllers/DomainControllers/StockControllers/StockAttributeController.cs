using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Constants;
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
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] StockAttributesDetailLevel detailLevel)
    {
        GetByCodeStockAttributeQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeStockAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] StockAttributesDetailLevel detailLevel)
    {
        GetByIdStockAttributeQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdStockAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] StockAttributesDetailLevel detailLevel)
    {
        GetListStockAttributeQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListStockAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] StockAttributeDynamicModel? dynamicModel = null)
    {
        GetListByDynamicStockAttributeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicStockAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
