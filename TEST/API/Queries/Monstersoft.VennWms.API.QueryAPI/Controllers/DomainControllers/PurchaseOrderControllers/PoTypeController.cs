using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.PurchaseOrderControllers;

public class PoTypeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodePoTypeQuery query = new() { Code = code };

        GetByCodePoTypeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdPoTypeQuery query = new() { Id = id };

        GetByIdPoTypeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListPoTypeQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListPoTypeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicPoTypeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicPoTypeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
