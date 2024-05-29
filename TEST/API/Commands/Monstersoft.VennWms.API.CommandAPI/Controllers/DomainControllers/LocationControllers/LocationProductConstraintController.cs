using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class LocationProductConstraintController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLocationProductConstraintCommand createLocationProductConstraintCommand)
    {
        CreatedLocationProductConstraintResponse response = await Mediator.Send(createLocationProductConstraintCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLocationProductConstraintCommand updateLocationProductConstraintCommand)
    {
        UpdatedLocationProductConstraintResponse response = await Mediator.Send(updateLocationProductConstraintCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteLocationProductConstraintCommand deleteLocationProductConstraintCommand)
    {
        DeletedLocationProductConstraintResponse response = await Mediator.Send(deleteLocationProductConstraintCommand);
        return Ok(response);
    }
}


