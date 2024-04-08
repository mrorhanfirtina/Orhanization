using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.CommonControllers;


public class LockReasonController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeLockReasonQuery query = new() { Code = code };

        GetByCodeLockReasonResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
    {
        GetByIdLockReasonQuery query = new() { Id = id };

        GetByIdLockReasonResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListLockReasonQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListLockReasonListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicLockReasonQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicLockReasonListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }
}
