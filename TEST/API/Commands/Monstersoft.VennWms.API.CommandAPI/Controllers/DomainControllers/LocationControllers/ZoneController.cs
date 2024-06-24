using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class ZoneController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateZoneCommand createZoneCommand)
    {
        CreatedZoneResponse response = await Mediator.Send(createZoneCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateZoneCommand updateZoneCommand)
    {
        UpdatedZoneResponse response = await Mediator.Send(updateZoneCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteZoneCommand deleteZoneCommand)
    {
        DeletedZoneResponse response = await Mediator.Send(deleteZoneCommand);
        return Ok(response);
    }
}

