using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LogControllers;

public class TransactionLogController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateTransactionLogCommand createTransactionLogCommand)
    {
        CreatedTransactionLogResponse response = await Mediator.Send(createTransactionLogCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateTransactionLogCommand updateTransactionLogCommand)
    {
        UpdatedTransactionLogResponse response = await Mediator.Send(updateTransactionLogCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteTransactionLogCommand deleteTransactionLogCommand)
    {
        DeletedTransactionLogResponse response = await Mediator.Send(deleteTransactionLogCommand);
        return Ok(response);
    }
}

