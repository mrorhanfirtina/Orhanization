using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ShipmentControllers;

public class ShipmentAttributeValueController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateShipmentAttributeValueCommand createShipmentAttributeValueCommand)
    {
        CreatedShipmentAttributeValueResponse response = await Mediator.Send(createShipmentAttributeValueCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateShipmentAttributeValueCommand updateShipmentAttributeValueCommand)
    {
        UpdatedShipmentAttributeValueResponse response = await Mediator.Send(updateShipmentAttributeValueCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteShipmentAttributeValueCommand deleteShipmentAttributeValueCommand)
    {
        DeletedShipmentAttributeValueResponse response = await Mediator.Send(deleteShipmentAttributeValueCommand);
        return Ok(response);
    }
}

