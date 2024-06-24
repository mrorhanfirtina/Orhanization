using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.TaskControllers;

public class TaskCodeFormatController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateTaskCodeFormatCommand createTaskCodeFormatCommand)
    {
        CreatedTaskCodeFormatResponse response = await Mediator.Send(createTaskCodeFormatCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateTaskCodeFormatCommand updateTaskCodeFormatCommand)
    {
        UpdatedTaskCodeFormatResponse response = await Mediator.Send(updateTaskCodeFormatCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteTaskCodeFormatCommand deleteTaskCodeFormatCommand)
    {
        DeletedTaskCodeFormatResponse response = await Mediator.Send(deleteTaskCodeFormatCommand);
        return Ok(response);
    }
}

