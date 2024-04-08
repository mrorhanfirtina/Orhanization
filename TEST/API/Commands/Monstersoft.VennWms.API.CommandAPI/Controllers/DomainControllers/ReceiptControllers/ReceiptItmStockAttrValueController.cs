using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ReceiptControllers;

public class ReceiptItmStockAttrValueController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReceiptItmStockAttrValueCommand createReceiptItmStockAttrValueCommand)
    {
        CreatedReceiptItmStockAttrValueResponse response = await Mediator.Send(createReceiptItmStockAttrValueCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReceiptItmStockAttrValueCommand updateReceiptItmStockAttrValueCommand)
    {
        UpdatedReceiptItmStockAttrValueResponse response = await Mediator.Send(updateReceiptItmStockAttrValueCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReceiptItmStockAttrValueCommand deleteReceiptItmStockAttrValueCommand)
    {
        DeletedReceiptItmStockAttrValueResponse response = await Mediator.Send(deleteReceiptItmStockAttrValueCommand);
        return Ok(response);
    }
}

