using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LogControllers;

public class LogStockController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLogStockCommand createLogStockCommand)
    {
        CreatedLogStockResponse response = await Mediator.Send(createLogStockCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLogStockCommand updateLogStockCommand)
    {
        UpdatedLogStockResponse response = await Mediator.Send(updateLogStockCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteLogStockCommand deleteLogStockCommand)
    {
        DeletedLogStockResponse response = await Mediator.Send(deleteLogStockCommand);
        return Ok(response);
    }
}

