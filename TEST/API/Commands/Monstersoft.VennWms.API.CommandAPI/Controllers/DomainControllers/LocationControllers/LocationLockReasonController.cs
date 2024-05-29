using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class LocationLockReasonController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLocationLockReasonCommand createLocationLockReasonCommand)
    {
        CreatedLocationLockReasonResponse response = await Mediator.Send(createLocationLockReasonCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLocationLockReasonCommand updateLocationLockReasonCommand)
    {
        UpdatedLocationLockReasonResponse response = await Mediator.Send(updateLocationLockReasonCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteLocationLockReasonCommand deleteLocationLockReasonCommand)
    {
        DeletedLocationLockReasonResponse response = await Mediator.Send(deleteLocationLockReasonCommand);
        return Ok(response);
    }
}


