using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ShipmentControllers;

public class ShipmentMemoController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateShipmentMemoCommand createShipmentMemoCommand)
    {
        CreatedShipmentMemoResponse response = await Mediator.Send(createShipmentMemoCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateShipmentMemoCommand updateShipmentMemoCommand)
    {
        UpdatedShipmentMemoResponse response = await Mediator.Send(updateShipmentMemoCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteShipmentMemoCommand deleteShipmentMemoCommand)
    {
        DeletedShipmentMemoResponse response = await Mediator.Send(deleteShipmentMemoCommand);
        return Ok(response);
    }
}

