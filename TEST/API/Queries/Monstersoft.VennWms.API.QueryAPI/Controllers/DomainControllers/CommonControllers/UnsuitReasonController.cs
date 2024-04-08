using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.CommonControllers;

public class UnsuitReasonController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeUnsuitReasonQuery query = new() { Code = code };

        GetByCodeUnsuitReasonResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdUnsuitReasonQuery query = new() { Id = id };

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
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicUnsuitReasonQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicUnsuitReasonListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
