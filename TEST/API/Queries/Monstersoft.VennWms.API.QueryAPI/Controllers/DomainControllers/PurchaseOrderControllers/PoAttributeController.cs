using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.PurchaseOrderControllers;

public class PoAttributeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodePoAttributeQuery query = new() { Code = code };

        GetByCodePoAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdPoAttributeQuery query = new() { Id = id };

        GetByIdPoAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListPoAttributeQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListPoAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicPoAttributeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicPoAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
