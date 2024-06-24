using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ReceiptControllers;

public class ReceiptAttributeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReceiptAttributeCommand createReceiptAttributeCommand)
    {
        CreatedReceiptAttributeResponse response = await Mediator.Send(createReceiptAttributeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReceiptAttributeCommand updateReceiptAttributeCommand)
    {
        UpdatedReceiptAttributeResponse response = await Mediator.Send(updateReceiptAttributeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReceiptAttributeCommand deleteReceiptAttributeCommand)
    {
        DeletedReceiptAttributeResponse response = await Mediator.Send(deleteReceiptAttributeCommand);
        return Ok(response);
    }
}

