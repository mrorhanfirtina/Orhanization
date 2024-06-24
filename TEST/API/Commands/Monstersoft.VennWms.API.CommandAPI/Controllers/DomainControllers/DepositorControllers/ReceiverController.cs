using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.DepositorControllers;

public class ReceiverController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReceiverCommand createReceiverCommand)
    {
        CreatedReceiverResponse response = await Mediator.Send(createReceiverCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReceiverCommand updateReceiverCommand)
    {
        UpdatedReceiverResponse response = await Mediator.Send(updateReceiverCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReceiverCommand deleteReceiverCommand)
    {
        DeletedReceiverResponse response = await Mediator.Send(deleteReceiverCommand);
        return Ok(response);
    }
}

