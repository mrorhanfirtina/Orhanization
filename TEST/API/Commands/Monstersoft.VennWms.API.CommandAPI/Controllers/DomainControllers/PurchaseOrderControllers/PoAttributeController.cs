using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.PurchaseOrderControllers;

public class PoAttributeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatePoAttributeCommand createPoAttributeCommand)
    {
        CreatedPoAttributeResponse response = await Mediator.Send(createPoAttributeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdatePoAttributeCommand updatePoAttributeCommand)
    {
        UpdatedPoAttributeResponse response = await Mediator.Send(updatePoAttributeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeletePoAttributeCommand deletePoAttributeCommand)
    {
        DeletedPoAttributeResponse response = await Mediator.Send(deletePoAttributeCommand);
        return Ok(response);
    }
}

