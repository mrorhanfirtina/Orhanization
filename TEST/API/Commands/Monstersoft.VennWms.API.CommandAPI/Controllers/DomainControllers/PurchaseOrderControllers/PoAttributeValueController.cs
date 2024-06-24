using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.PurchaseOrderControllers;

public class PoAttributeValueController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatePoAttributeValueCommand createPoAttributeValueCommand)
    {
        CreatedPoAttributeValueResponse response = await Mediator.Send(createPoAttributeValueCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdatePoAttributeValueCommand updatePoAttributeValueCommand)
    {
        UpdatedPoAttributeValueResponse response = await Mediator.Send(updatePoAttributeValueCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeletePoAttributeValueCommand deletePoAttributeValueCommand)
    {
        DeletedPoAttributeValueResponse response = await Mediator.Send(deletePoAttributeValueCommand);
        return Ok(response);
    }
}

