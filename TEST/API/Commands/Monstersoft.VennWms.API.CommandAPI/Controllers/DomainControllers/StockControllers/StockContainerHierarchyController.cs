using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.StockControllers;

public class StockContainerHierarchyController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateStockContainerHierarchyCommand createStockContainerHierarchyCommand)
    {
        CreatedStockContainerHierarchyResponse response = await Mediator.Send(createStockContainerHierarchyCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateStockContainerHierarchyCommand updateStockContainerHierarchyCommand)
    {
        UpdatedStockContainerHierarchyResponse response = await Mediator.Send(updateStockContainerHierarchyCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteStockContainerHierarchyCommand deleteStockContainerHierarchyCommand)
    {
        DeletedStockContainerHierarchyResponse response = await Mediator.Send(deleteStockContainerHierarchyCommand);
        return Ok(response);
    }
}

