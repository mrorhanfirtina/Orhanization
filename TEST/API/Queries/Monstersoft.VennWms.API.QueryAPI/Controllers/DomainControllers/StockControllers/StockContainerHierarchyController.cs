using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.StockControllers;

public class StockContainerHierarchyController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] StockContainerHierarchiesDetailLevel detailLevel)
    {
        GetByIdStockContainerHierarchyQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdStockContainerHierarchyResponse result = await Mediator.Send(query);

        return Ok(result);
    }


    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] StockContainerHierarchyDynamicModel? dynamicModel = null)
    {
        GetListByDynamicStockContainerHierarchyQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicStockContainerHierarchyListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}

