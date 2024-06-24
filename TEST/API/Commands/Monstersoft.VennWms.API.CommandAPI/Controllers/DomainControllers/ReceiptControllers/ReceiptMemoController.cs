using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ReceiptControllers;

public class ReceiptMemoController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReceiptMemoCommand createReceiptMemoCommand)
    {
        CreatedReceiptMemoResponse response = await Mediator.Send(createReceiptMemoCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReceiptMemoCommand updateReceiptMemoCommand)
    {
        UpdatedReceiptMemoResponse response = await Mediator.Send(updateReceiptMemoCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReceiptMemoCommand deleteReceiptMemoCommand)
    {
        DeletedReceiptMemoResponse response = await Mediator.Send(deleteReceiptMemoCommand);
        return Ok(response);
    }
}

