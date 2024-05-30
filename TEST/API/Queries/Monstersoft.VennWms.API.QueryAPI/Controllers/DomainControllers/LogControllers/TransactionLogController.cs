using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LoggingDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LogControllers;

public class TransactionLogController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] TransactionLogsDetailLevel detailLevel)
    {
        GetByIdTransactionLogQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdTransactionLogResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] TransactionLogsDetailLevel detailLevel)
    {
        GetListTransactionLogQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListTransactionLogListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] TransactionLogDynamicModel? dynamicModel = null)
    {
        GetListByDynamicTransactionLogQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicTransactionLogListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
