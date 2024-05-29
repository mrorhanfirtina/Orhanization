using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class LocationDepositorController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLocationDepositorCommand createLocationDepositorCommand)
    {
        CreatedLocationDepositorResponse response = await Mediator.Send(createLocationDepositorCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLocationDepositorCommand updateLocationDepositorCommand)
    {
        UpdatedLocationDepositorResponse response = await Mediator.Send(updateLocationDepositorCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteLocationDepositorCommand deleteLocationDepositorCommand)
    {
        DeletedLocationDepositorResponse response = await Mediator.Send(deleteLocationDepositorCommand);
        return Ok(response);
    }
}


