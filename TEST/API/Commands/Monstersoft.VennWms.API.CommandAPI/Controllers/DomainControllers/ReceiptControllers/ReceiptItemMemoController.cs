using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ReceiptControllers;

public class ReceiptItemMemoController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReceiptItemMemoCommand createReceiptItemMemoCommand)
    {
        CreatedReceiptItemMemoResponse response = await Mediator.Send(createReceiptItemMemoCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReceiptItemMemoCommand updateReceiptItemMemoCommand)
    {
        UpdatedReceiptItemMemoResponse response = await Mediator.Send(updateReceiptItemMemoCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReceiptItemMemoCommand deleteReceiptItemMemoCommand)
    {
        DeletedReceiptItemMemoResponse response = await Mediator.Send(deleteReceiptItemMemoCommand);
        return Ok(response);
    }
}

