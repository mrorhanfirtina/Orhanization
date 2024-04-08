using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.StockControllers;

public class StockPackTypeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateStockPackTypeCommand createStockPackTypeCommand)
    {
        CreatedStockPackTypeResponse response = await Mediator.Send(createStockPackTypeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateStockPackTypeCommand updateStockPackTypeCommand)
    {
        UpdatedStockPackTypeResponse response = await Mediator.Send(updateStockPackTypeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteStockPackTypeCommand deleteStockPackTypeCommand)
    {
        DeletedStockPackTypeResponse response = await Mediator.Send(deleteStockPackTypeCommand);
        return Ok(response);
    }
}

