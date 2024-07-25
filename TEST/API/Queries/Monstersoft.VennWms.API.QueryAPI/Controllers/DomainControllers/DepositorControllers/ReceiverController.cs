using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.DepositorDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Constants;
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
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] ReceiversDetailLevel detailLevel)
    {
        GetByCodeReceiverQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeReceiverResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ReceiversDetailLevel detailLevel)
    {
        GetByIdReceiverQuery query = new() { Id = id, DetailLevel = detailLevel };

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
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ReceiverDynamicModel? dynamicModel = null)
    {
        GetListByDynamicReceiverQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicReceiverListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
