using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ReceiptControllers;

public class ReceiptItemController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReceiptItemCommand createReceiptItemCommand)
    {
        CreatedReceiptItemResponse response = await Mediator.Send(createReceiptItemCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReceiptItemCommand updateReceiptItemCommand)
    {
        UpdatedReceiptItemResponse response = await Mediator.Send(updateReceiptItemCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReceiptItemCommand deleteReceiptItemCommand)
    {
        DeletedReceiptItemResponse response = await Mediator.Send(deleteReceiptItemCommand);
        return Ok(response);
    }
}

