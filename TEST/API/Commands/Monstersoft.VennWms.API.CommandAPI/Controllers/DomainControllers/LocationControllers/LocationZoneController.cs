using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class LocationZoneController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLocationZoneCommand createLocationZoneCommand)
    {
        CreatedLocationZoneResponse response = await Mediator.Send(createLocationZoneCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLocationZoneCommand updateLocationZoneCommand)
    {
        UpdatedLocationZoneResponse response = await Mediator.Send(updateLocationZoneCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteLocationZoneCommand deleteLocationZoneCommand)
    {
        DeletedLocationZoneResponse response = await Mediator.Send(deleteLocationZoneCommand);
        return Ok(response);
    }
}

