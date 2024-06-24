using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ReceiptControllers;

public class ReceiptController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReceiptCommand createReceiptCommand)
    {
        CreatedReceiptResponse response = await Mediator.Send(createReceiptCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReceiptCommand updateReceiptCommand)
    {
        UpdatedReceiptResponse response = await Mediator.Send(updateReceiptCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReceiptCommand deleteReceiptCommand)
    {
        DeletedReceiptResponse response = await Mediator.Send(deleteReceiptCommand);
        return Ok(response);
    }
}

