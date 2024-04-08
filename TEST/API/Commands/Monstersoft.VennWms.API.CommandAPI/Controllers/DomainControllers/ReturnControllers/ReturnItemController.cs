using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ReturnControllers;

public class ReturnItemController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReturnItemCommand createReturnItemCommand)
    {
        CreatedReturnItemResponse response = await Mediator.Send(createReturnItemCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReturnItemCommand updateReturnItemCommand)
    {
        UpdatedReturnItemResponse response = await Mediator.Send(updateReturnItemCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReturnItemCommand deleteReturnItemCommand)
    {
        DeletedReturnItemResponse response = await Mediator.Send(deleteReturnItemCommand);
        return Ok(response);
    }
}

