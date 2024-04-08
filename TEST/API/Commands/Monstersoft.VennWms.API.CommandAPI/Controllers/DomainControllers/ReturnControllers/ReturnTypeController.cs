using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ReturnControllers;

public class ReturnTypeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReturnTypeCommand createReturnTypeCommand)
    {
        CreatedReturnTypeResponse response = await Mediator.Send(createReturnTypeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReturnTypeCommand updateReturnTypeCommand)
    {
        UpdatedReturnTypeResponse response = await Mediator.Send(updateReturnTypeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReturnTypeCommand deleteReturnTypeCommand)
    {
        DeletedReturnTypeResponse response = await Mediator.Send(deleteReturnTypeCommand);
        return Ok(response);
    }
}

