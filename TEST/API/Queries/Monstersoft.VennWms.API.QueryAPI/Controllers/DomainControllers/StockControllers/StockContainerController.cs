using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.StockControllers;

public class StockContainerController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] StockContainersDetailLevel detailLevel)
    {
        GetByIdStockContainerQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdStockContainerResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] StockContainerDynamicModel? dynamicModel = null)
    {
        GetListByDynamicStockContainerQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicStockContainerListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
