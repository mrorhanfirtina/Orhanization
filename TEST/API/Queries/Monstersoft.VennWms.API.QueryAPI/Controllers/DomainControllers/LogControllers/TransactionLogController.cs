using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LogControllers;

public class TransactionLogController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdTransactionLogQuery query = new() { Id = id };

        GetByIdTransactionLogResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListTransactionLogQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListTransactionLogListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicTransactionLogQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicTransactionLogListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
