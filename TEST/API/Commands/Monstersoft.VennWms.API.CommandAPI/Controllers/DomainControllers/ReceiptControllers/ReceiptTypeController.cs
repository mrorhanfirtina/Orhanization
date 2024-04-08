using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ReceiptControllers;

public class ReceiptTypeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReceiptTypeCommand createReceiptTypeCommand)
    {
        CreatedReceiptTypeResponse response = await Mediator.Send(createReceiptTypeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReceiptTypeCommand updateReceiptTypeCommand)
    {
        UpdatedReceiptTypeResponse response = await Mediator.Send(updateReceiptTypeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReceiptTypeCommand deleteReceiptTypeCommand)
    {
        DeletedReceiptTypeResponse response = await Mediator.Send(deleteReceiptTypeCommand);
        return Ok(response);
    }
}

