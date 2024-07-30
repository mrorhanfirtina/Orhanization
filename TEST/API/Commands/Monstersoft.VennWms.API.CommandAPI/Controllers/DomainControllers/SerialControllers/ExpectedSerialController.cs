using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.SerialControllers;

public class ExpectedSerialController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateExpectedSerialCommand createExpectedSerialCommand)
    {
        CreatedExpectedSerialResponse response = await Mediator.Send(createExpectedSerialCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateExpectedSerialCommand updateExpectedSerialCommand)
    {
        UpdatedExpectedSerialResponse response = await Mediator.Send(updateExpectedSerialCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteExpectedSerialCommand deleteExpectedSerialCommand)
    {
        DeletedExpectedSerialResponse response = await Mediator.Send(deleteExpectedSerialCommand);
        return Ok(response);
    }
}

