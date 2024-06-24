using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ReturnControllers;

public class ReturnAttributeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReturnAttributeCommand createReturnAttributeCommand)
    {
        CreatedReturnAttributeResponse response = await Mediator.Send(createReturnAttributeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReturnAttributeCommand updateReturnAttributeCommand)
    {
        UpdatedReturnAttributeResponse response = await Mediator.Send(updateReturnAttributeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReturnAttributeCommand deleteReturnAttributeCommand)
    {
        DeletedReturnAttributeResponse response = await Mediator.Send(deleteReturnAttributeCommand);
        return Ok(response);
    }
}

