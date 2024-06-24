using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.TaskControllers;

public class TaskListController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateTaskListCommand createTaskListCommand)
    {
        CreatedTaskListResponse response = await Mediator.Send(createTaskListCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateTaskListCommand updateTaskListCommand)
    {
        UpdatedTaskListResponse response = await Mediator.Send(updateTaskListCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteTaskListCommand deleteTaskListCommand)
    {
        DeletedTaskListResponse response = await Mediator.Send(deleteTaskListCommand);
        return Ok(response);
    }
}

