using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ReturnControllers;

public class ReturnController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReturnCommand createReturnCommand)
    {
        CreatedReturnResponse response = await Mediator.Send(createReturnCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReturnCommand updateReturnCommand)
    {
        UpdatedReturnResponse response = await Mediator.Send(updateReturnCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReturnCommand deleteReturnCommand)
    {
        DeletedReturnResponse response = await Mediator.Send(deleteReturnCommand);
        return Ok(response);
    }
}

