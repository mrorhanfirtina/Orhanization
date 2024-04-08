using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.StockControllers;

public class StockMemoController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateStockMemoCommand createStockMemoCommand)
    {
        CreatedStockMemoResponse response = await Mediator.Send(createStockMemoCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateStockMemoCommand updateStockMemoCommand)
    {
        UpdatedStockMemoResponse response = await Mediator.Send(updateStockMemoCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteStockMemoCommand deleteStockMemoCommand)
    {
        DeletedStockMemoResponse response = await Mediator.Send(deleteStockMemoCommand);
        return Ok(response);
    }
}

