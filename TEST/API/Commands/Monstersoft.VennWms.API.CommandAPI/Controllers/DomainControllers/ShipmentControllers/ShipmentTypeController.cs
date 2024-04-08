using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ShipmentControllers;

public class ShipmentTypeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateShipmentTypeCommand createShipmentTypeCommand)
    {
        CreatedShipmentTypeResponse response = await Mediator.Send(createShipmentTypeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateShipmentTypeCommand updateShipmentTypeCommand)
    {
        UpdatedShipmentTypeResponse response = await Mediator.Send(updateShipmentTypeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteShipmentTypeCommand deleteShipmentTypeCommand)
    {
        DeletedShipmentTypeResponse response = await Mediator.Send(deleteShipmentTypeCommand);
        return Ok(response);
    }
}

