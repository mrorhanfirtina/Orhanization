using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.StockControllers;

public class StockUnsuitReasonController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateStockUnsuitReasonCommand createStockUnsuitReasonCommand)
    {
        CreatedStockUnsuitReasonResponse response = await Mediator.Send(createStockUnsuitReasonCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateStockUnsuitReasonCommand updateStockUnsuitReasonCommand)
    {
        UpdatedStockUnsuitReasonResponse response = await Mediator.Send(updateStockUnsuitReasonCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteStockUnsuitReasonCommand deleteStockUnsuitReasonCommand)
    {
        DeletedStockUnsuitReasonResponse response = await Mediator.Send(deleteStockUnsuitReasonCommand);
        return Ok(response);
    }
}

