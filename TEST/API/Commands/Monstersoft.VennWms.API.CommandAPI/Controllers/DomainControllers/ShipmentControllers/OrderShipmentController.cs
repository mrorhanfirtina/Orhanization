using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ShipmentControllers;

public class OrderShipmentController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateOrderShipmentCommand createOrderShipmentCommand)
    {
        CreatedOrderShipmentResponse response = await Mediator.Send(createOrderShipmentCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOrderShipmentCommand updateOrderShipmentCommand)
    {
        UpdatedOrderShipmentResponse response = await Mediator.Send(updateOrderShipmentCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteOrderShipmentCommand deleteOrderShipmentCommand)
    {
        DeletedOrderShipmentResponse response = await Mediator.Send(deleteOrderShipmentCommand);
        return Ok(response);
    }
}

