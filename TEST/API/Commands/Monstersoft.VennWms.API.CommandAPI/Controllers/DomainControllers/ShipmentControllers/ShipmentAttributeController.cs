using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ShipmentControllers;

public class ShipmentAttributeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateShipmentAttributeCommand createShipmentAttributeCommand)
    {
        CreatedShipmentAttributeResponse response = await Mediator.Send(createShipmentAttributeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateShipmentAttributeCommand updateShipmentAttributeCommand)
    {
        UpdatedShipmentAttributeResponse response = await Mediator.Send(updateShipmentAttributeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteShipmentAttributeCommand deleteShipmentAttributeCommand)
    {
        DeletedShipmentAttributeResponse response = await Mediator.Send(deleteShipmentAttributeCommand);
        return Ok(response);
    }
}

