using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.TaskControllers;

public class TransactionTypeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateTransactionTypeCommand createTransactionTypeCommand)
    {
        CreatedTransactionTypeResponse response = await Mediator.Send(createTransactionTypeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateTransactionTypeCommand updateTransactionTypeCommand)
    {
        UpdatedTransactionTypeResponse response = await Mediator.Send(updateTransactionTypeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteTransactionTypeCommand deleteTransactionTypeCommand)
    {
        DeletedTransactionTypeResponse response = await Mediator.Send(deleteTransactionTypeCommand);
        return Ok(response);
    }
}

