using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.StockControllers;

public class StockInboundController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateStockInboundCommand createStockInboundCommand)
    {
        CreatedStockInboundResponse response = await Mediator.Send(createStockInboundCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateStockInboundCommand updateStockInboundCommand)
    {
        UpdatedStockInboundResponse response = await Mediator.Send(updateStockInboundCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteStockInboundCommand deleteStockInboundCommand)
    {
        DeletedStockInboundResponse response = await Mediator.Send(deleteStockInboundCommand);
        return Ok(response);
    }
}

