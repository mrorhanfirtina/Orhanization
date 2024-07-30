using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.SerialControllers;

public class SerialController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateSerialCommand createSerialCommand)
    {
        CreatedSerialResponse response = await Mediator.Send(createSerialCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateSerialCommand updateSerialCommand)
    {
        UpdatedSerialResponse response = await Mediator.Send(updateSerialCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteSerialCommand deleteSerialCommand)
    {
        DeletedSerialResponse response = await Mediator.Send(deleteSerialCommand);
        return Ok(response);
    }
}

