using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.SerialControllers;

public class SerialLogController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateSerialLogCommand createSerialLogCommand)
    {
        CreatedSerialLogResponse response = await Mediator.Send(createSerialLogCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateSerialLogCommand updateSerialLogCommand)
    {
        UpdatedSerialLogResponse response = await Mediator.Send(updateSerialLogCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteSerialLogCommand deleteSerialLogCommand)
    {
        DeletedSerialLogResponse response = await Mediator.Send(deleteSerialLogCommand);
        return Ok(response);
    }
}

