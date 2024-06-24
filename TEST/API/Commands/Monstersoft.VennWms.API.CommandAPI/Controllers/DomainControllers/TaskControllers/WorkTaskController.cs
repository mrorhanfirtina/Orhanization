using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.TaskControllers;

public class WorkTaskController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateWorkTaskCommand createWorkTaskCommand)
    {
        CreatedWorkTaskResponse response = await Mediator.Send(createWorkTaskCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateWorkTaskCommand updateWorkTaskCommand)
    {
        UpdatedWorkTaskResponse response = await Mediator.Send(updateWorkTaskCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteWorkTaskCommand deleteWorkTaskCommand)
    {
        DeletedWorkTaskResponse response = await Mediator.Send(deleteWorkTaskCommand);
        return Ok(response);
    }
}

