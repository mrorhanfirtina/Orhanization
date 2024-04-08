using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ReturnControllers;

public class ReturnAttributeValueController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReturnAttributeValueCommand createReturnAttributeValueCommand)
    {
        CreatedReturnAttributeValueResponse response = await Mediator.Send(createReturnAttributeValueCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReturnAttributeValueCommand updateReturnAttributeValueCommand)
    {
        UpdatedReturnAttributeValueResponse response = await Mediator.Send(updateReturnAttributeValueCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReturnAttributeValueCommand deleteReturnAttributeValueCommand)
    {
        DeletedReturnAttributeValueResponse response = await Mediator.Send(deleteReturnAttributeValueCommand);
        return Ok(response);
    }
}

