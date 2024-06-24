using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.StockControllers;

public class StockAttributeValueController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateStockAttributeValueCommand createStockAttributeValueCommand)
    {
        CreatedStockAttributeValueResponse response = await Mediator.Send(createStockAttributeValueCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateStockAttributeValueCommand updateStockAttributeValueCommand)
    {
        UpdatedStockAttributeValueResponse response = await Mediator.Send(updateStockAttributeValueCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteStockAttributeValueCommand deleteStockAttributeValueCommand)
    {
        DeletedStockAttributeValueResponse response = await Mediator.Send(deleteStockAttributeValueCommand);
        return Ok(response);
    }
}

