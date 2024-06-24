using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.StockControllers;

public class StockContainerController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateStockContainerCommand createStockContainerCommand)
    {
        CreatedStockContainerResponse response = await Mediator.Send(createStockContainerCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateStockContainerCommand updateStockContainerCommand)
    {
        UpdatedStockContainerResponse response = await Mediator.Send(updateStockContainerCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteStockContainerCommand deleteStockContainerCommand)
    {
        DeletedStockContainerResponse response = await Mediator.Send(deleteStockContainerCommand);
        return Ok(response);
    }
}

