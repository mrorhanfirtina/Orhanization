using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class LocationProductController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLocationProductCommand createLocationProductCommand)
    {
        CreatedLocationProductResponse response = await Mediator.Send(createLocationProductCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLocationProductCommand updateLocationProductCommand)
    {
        UpdatedLocationProductResponse response = await Mediator.Send(updateLocationProductCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteLocationProductCommand deleteLocationProductCommand)
    {
        DeletedLocationProductResponse response = await Mediator.Send(deleteLocationProductCommand);
        return Ok(response);
    }
}

