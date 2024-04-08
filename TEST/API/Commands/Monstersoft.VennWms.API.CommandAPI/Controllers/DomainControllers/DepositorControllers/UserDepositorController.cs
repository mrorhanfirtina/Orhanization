using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.DepositorControllers;

public class UserDepositorController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateUserDepositorCommand createUserDepositorCommand)
    {
        CreatedUserDepositorResponse response = await Mediator.Send(createUserDepositorCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateUserDepositorCommand updateUserDepositorCommand)
    {
        UpdatedUserDepositorResponse response = await Mediator.Send(updateUserDepositorCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteUserDepositorCommand deleteUserDepositorCommand)
    {
        DeletedUserDepositorResponse response = await Mediator.Send(deleteUserDepositorCommand);
        return Ok(response);
    }
}

