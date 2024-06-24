using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.StockControllers;

public class TaskStockController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateTaskStockCommand createTaskStockCommand)
    {
        CreatedTaskStockResponse response = await Mediator.Send(createTaskStockCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateTaskStockCommand updateTaskStockCommand)
    {
        UpdatedTaskStockResponse response = await Mediator.Send(updateTaskStockCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteTaskStockCommand deleteTaskStockCommand)
    {
        DeletedTaskStockResponse response = await Mediator.Send(deleteTaskStockCommand);
        return Ok(response);
    }
}

