using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.CommonControllers;


public class LockReasonController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLockReasonCommand createLockReasonCommand)
    {
        CreatedLockReasonResponse response = await Mediator.Send(createLockReasonCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLockReasonCommand updateLockReasonCommand)
    {
        UpdatedLockReasonResponse response = await Mediator.Send(updateLockReasonCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteLockReasonCommand deleteLockReasonCommand)
    {
        DeletedLockReasonResponse response = await Mediator.Send(deleteLockReasonCommand);
        return Ok(response);
    }

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
