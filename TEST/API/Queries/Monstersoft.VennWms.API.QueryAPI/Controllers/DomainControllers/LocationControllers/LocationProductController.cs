using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LocationControllers;

public class LocationProductController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdLocationProductQuery query = new() { Id = id };

        GetByIdLocationProductResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicLocationProductQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicLocationProductListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
