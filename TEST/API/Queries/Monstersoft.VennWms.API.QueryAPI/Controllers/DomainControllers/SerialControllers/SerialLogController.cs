using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.SerialDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Queries.GetListByDynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.SerialControllers;

public class SerialLogController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] SerialLogsDetailLevel detailLevel)
    {
        GetByIdSerialLogQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdSerialLogResponse result = await Mediator.Send(query);

        return Ok(result);
    }


    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] SerialLogDynamicModel? dynamicModel = null)
    {
        GetListByDynamicSerialLogQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicSerialLogListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}

