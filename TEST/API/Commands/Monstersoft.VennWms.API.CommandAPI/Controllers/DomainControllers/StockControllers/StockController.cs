using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.StockControllers;

public class StockController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateStockCommand createStockCommand)
    {
        CreatedStockResponse response = await Mediator.Send(createStockCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateStockCommand updateStockCommand)
    {
        UpdatedStockResponse response = await Mediator.Send(updateStockCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteStockCommand deleteStockCommand)
    {
        DeletedStockResponse response = await Mediator.Send(deleteStockCommand);
        return Ok(response);
    }
}

