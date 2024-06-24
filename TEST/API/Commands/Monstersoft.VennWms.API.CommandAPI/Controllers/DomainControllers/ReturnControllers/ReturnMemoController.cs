using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ReturnControllers;

public class ReturnMemoController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReturnMemoCommand createReturnMemoCommand)
    {
        CreatedReturnMemoResponse response = await Mediator.Send(createReturnMemoCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReturnMemoCommand updateReturnMemoCommand)
    {
        UpdatedReturnMemoResponse response = await Mediator.Send(updateReturnMemoCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReturnMemoCommand deleteReturnMemoCommand)
    {
        DeletedReturnMemoResponse response = await Mediator.Send(deleteReturnMemoCommand);
        return Ok(response);
    }
}

