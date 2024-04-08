using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.OrderControllers;

public class OrderTypeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeOrderTypeQuery query = new() { Code = code };

        GetByCodeOrderTypeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdOrderTypeQuery query = new() { Id = id };

        GetByIdOrderTypeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListOrderTypeQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListOrderTypeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicOrderTypeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicOrderTypeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
