using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ShipmentControllers;

public class OrderShipItemController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateOrderShipItemCommand createOrderShipItemCommand)
    {
        CreatedOrderShipItemResponse response = await Mediator.Send(createOrderShipItemCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOrderShipItemCommand updateOrderShipItemCommand)
    {
        UpdatedOrderShipItemResponse response = await Mediator.Send(updateOrderShipItemCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteOrderShipItemCommand deleteOrderShipItemCommand)
    {
        DeletedOrderShipItemResponse response = await Mediator.Send(deleteOrderShipItemCommand);
        return Ok(response);
    }
}

