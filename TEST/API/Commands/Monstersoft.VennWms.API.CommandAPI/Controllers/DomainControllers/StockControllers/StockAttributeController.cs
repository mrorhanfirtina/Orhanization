using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.StockControllers;

public class StockAttributeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateStockAttributeCommand createStockAttributeCommand)
    {
        CreatedStockAttributeResponse response = await Mediator.Send(createStockAttributeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateStockAttributeCommand updateStockAttributeCommand)
    {
        UpdatedStockAttributeResponse response = await Mediator.Send(updateStockAttributeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteStockAttributeCommand deleteStockAttributeCommand)
    {
        DeletedStockAttributeResponse response = await Mediator.Send(deleteStockAttributeCommand);
        return Ok(response);
    }
}

