using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class LocationStockAttributeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLocationStockAttributeCommand createLocationStockAttributeCommand)
    {
        CreatedLocationStockAttributeResponse response = await Mediator.Send(createLocationStockAttributeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLocationStockAttributeCommand updateLocationStockAttributeCommand)
    {
        UpdatedLocationStockAttributeResponse response = await Mediator.Send(updateLocationStockAttributeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteLocationStockAttributeCommand deleteLocationStockAttributeCommand)
    {
        DeletedLocationStockAttributeResponse response = await Mediator.Send(deleteLocationStockAttributeCommand);
        return Ok(response);
    }
}

