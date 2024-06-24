using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ReturnControllers;

public class ReturnItmStockAttrValueController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReturnItmStockAttrValueCommand createReturnItmStockAttrValueCommand)
    {
        CreatedReturnItmStockAttrValueResponse response = await Mediator.Send(createReturnItmStockAttrValueCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReturnItmStockAttrValueCommand updateReturnItmStockAttrValueCommand)
    {
        UpdatedReturnItmStockAttrValueResponse response = await Mediator.Send(updateReturnItmStockAttrValueCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReturnItmStockAttrValueCommand deleteReturnItmStockAttrValueCommand)
    {
        DeletedReturnItmStockAttrValueResponse response = await Mediator.Send(deleteReturnItmStockAttrValueCommand);
        return Ok(response);
    }
}

