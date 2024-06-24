using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.PurchaseOrderControllers;

public class PoTypeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatePoTypeCommand createPoTypeCommand)
    {
        CreatedPoTypeResponse response = await Mediator.Send(createPoTypeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdatePoTypeCommand updatePoTypeCommand)
    {
        UpdatedPoTypeResponse response = await Mediator.Send(updatePoTypeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeletePoTypeCommand deletePoTypeCommand)
    {
        DeletedPoTypeResponse response = await Mediator.Send(deletePoTypeCommand);
        return Ok(response);
    }
}

