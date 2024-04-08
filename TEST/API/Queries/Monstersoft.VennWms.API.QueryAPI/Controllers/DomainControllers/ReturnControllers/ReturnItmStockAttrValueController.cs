using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ReturnControllers;

public class ReturnItmStockAttrValueController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdReturnItmStockAttrValueQuery query = new() { Id = id };

        GetByIdReturnItmStockAttrValueResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicReturnItmStockAttrValueQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicReturnItmStockAttrValueListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
