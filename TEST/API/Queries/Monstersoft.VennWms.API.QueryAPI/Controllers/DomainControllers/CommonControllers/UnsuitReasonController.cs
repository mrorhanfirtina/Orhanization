using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.CommonControllers;

public class UnsuitReasonController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] UnsuitReasonsDetailLevel detailLevel)
    {
        GetByCodeUnsuitReasonQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeUnsuitReasonResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] UnsuitReasonsDetailLevel detailLevel)
    {
        GetByIdUnsuitReasonQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdUnsuitReasonResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListUnsuitReasonQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListUnsuitReasonListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] UnsuitReasonDynamicModel? dynamicModel = null)
    {
        GetListByDynamicUnsuitReasonQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicUnsuitReasonListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
