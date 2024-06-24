using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ReturnControllers;

public class ReturnItemMemoController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReturnItemMemoCommand createReturnItemMemoCommand)
    {
        CreatedReturnItemMemoResponse response = await Mediator.Send(createReturnItemMemoCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReturnItemMemoCommand updateReturnItemMemoCommand)
    {
        UpdatedReturnItemMemoResponse response = await Mediator.Send(updateReturnItemMemoCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReturnItemMemoCommand deleteReturnItemMemoCommand)
    {
        DeletedReturnItemMemoResponse response = await Mediator.Send(deleteReturnItemMemoCommand);
        return Ok(response);
    }
}

