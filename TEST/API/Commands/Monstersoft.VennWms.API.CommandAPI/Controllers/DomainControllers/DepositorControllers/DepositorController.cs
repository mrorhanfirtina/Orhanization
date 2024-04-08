using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.DepositorControllers;

public class DepositorController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateDepositorCommand createDepositorCommand)
    {
        CreatedDepositorResponse response = await Mediator.Send(createDepositorCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateDepositorCommand updateDepositorCommand)
    {
        UpdatedDepositorResponse response = await Mediator.Send(updateDepositorCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteDepositorCommand deleteDepositorCommand)
    {
        DeletedDepositorResponse response = await Mediator.Send(deleteDepositorCommand);
        return Ok(response);
    }
}

