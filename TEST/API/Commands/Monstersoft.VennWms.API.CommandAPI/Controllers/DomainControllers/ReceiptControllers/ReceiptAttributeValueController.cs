using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ReceiptControllers;

public class ReceiptAttributeValueController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReceiptAttributeValueCommand createReceiptAttributeValueCommand)
    {
        CreatedReceiptAttributeValueResponse response = await Mediator.Send(createReceiptAttributeValueCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReceiptAttributeValueCommand updateReceiptAttributeValueCommand)
    {
        UpdatedReceiptAttributeValueResponse response = await Mediator.Send(updateReceiptAttributeValueCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReceiptAttributeValueCommand deleteReceiptAttributeValueCommand)
    {
        DeletedReceiptAttributeValueResponse response = await Mediator.Send(deleteReceiptAttributeValueCommand);
        return Ok(response);
    }
}

