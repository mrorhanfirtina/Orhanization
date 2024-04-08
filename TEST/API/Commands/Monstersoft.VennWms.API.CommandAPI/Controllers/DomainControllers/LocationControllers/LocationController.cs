using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class LocationController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLocationCommand createLocationCommand)
    {
        CreatedLocationResponse response = await Mediator.Send(createLocationCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLocationCommand updateLocationCommand)
    {
        UpdatedLocationResponse response = await Mediator.Send(updateLocationCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteLocationCommand deleteLocationCommand)
    {
        DeletedLocationResponse response = await Mediator.Send(deleteLocationCommand);
        return Ok(response);
    }
}

