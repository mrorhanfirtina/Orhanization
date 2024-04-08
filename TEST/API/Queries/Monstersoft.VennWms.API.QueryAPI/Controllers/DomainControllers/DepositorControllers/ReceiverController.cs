using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.DepositorControllers;

public class ReceiverController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeReceiverQuery query = new() { Code = code };

        GetByCodeReceiverResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdReceiverQuery query = new() { Id = id };

        GetByIdReceiverResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListReceiverQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListReceiverListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicReceiverQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicReceiverListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
