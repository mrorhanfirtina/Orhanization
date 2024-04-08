using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.StockControllers;

public class StockReserveReasonController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateStockReserveReasonCommand createStockReserveReasonCommand)
    {
        CreatedStockReserveReasonResponse response = await Mediator.Send(createStockReserveReasonCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateStockReserveReasonCommand updateStockReserveReasonCommand)
    {
        UpdatedStockReserveReasonResponse response = await Mediator.Send(updateStockReserveReasonCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteStockReserveReasonCommand deleteStockReserveReasonCommand)
    {
        DeletedStockReserveReasonResponse response = await Mediator.Send(deleteStockReserveReasonCommand);
        return Ok(response);
    }
}

