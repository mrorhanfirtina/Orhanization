using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class LocationUnitConstraintController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLocationUnitConstraintCommand createLocationUnitConstraintCommand)
    {
        CreatedLocationUnitConstraintResponse response = await Mediator.Send(createLocationUnitConstraintCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLocationUnitConstraintCommand updateLocationUnitConstraintCommand)
    {
        UpdatedLocationUnitConstraintResponse response = await Mediator.Send(updateLocationUnitConstraintCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteLocationUnitConstraintCommand deleteLocationUnitConstraintCommand)
    {
        DeletedLocationUnitConstraintResponse response = await Mediator.Send(deleteLocationUnitConstraintCommand);
        return Ok(response);
    }
}


