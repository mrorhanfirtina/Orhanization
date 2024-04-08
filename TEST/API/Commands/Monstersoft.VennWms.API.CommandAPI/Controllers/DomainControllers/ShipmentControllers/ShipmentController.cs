using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ShipmentControllers;

public class ShipmentController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateShipmentCommand createShipmentCommand)
    {
        CreatedShipmentResponse response = await Mediator.Send(createShipmentCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateShipmentCommand updateShipmentCommand)
    {
        UpdatedShipmentResponse response = await Mediator.Send(updateShipmentCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteShipmentCommand deleteShipmentCommand)
    {
        DeletedShipmentResponse response = await Mediator.Send(deleteShipmentCommand);
        return Ok(response);
    }
}

