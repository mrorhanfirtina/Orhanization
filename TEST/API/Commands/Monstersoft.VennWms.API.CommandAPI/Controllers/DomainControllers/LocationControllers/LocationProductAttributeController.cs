using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class LocationProductAttributeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLocationProductAttributeCommand createLocationProductAttributeCommand)
    {
        CreatedLocationProductAttributeResponse response = await Mediator.Send(createLocationProductAttributeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLocationProductAttributeCommand updateLocationProductAttributeCommand)
    {
        UpdatedLocationProductAttributeResponse response = await Mediator.Send(updateLocationProductAttributeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteLocationProductAttributeCommand deleteLocationProductAttributeCommand)
    {
        DeletedLocationProductAttributeResponse response = await Mediator.Send(deleteLocationProductAttributeCommand);
        return Ok(response);
    }
}

