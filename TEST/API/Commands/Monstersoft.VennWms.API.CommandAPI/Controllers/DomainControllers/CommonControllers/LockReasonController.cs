using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Update;

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
}
