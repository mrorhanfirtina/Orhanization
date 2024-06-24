using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ShipmentControllers;

public class OrderShipItemTaskController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateOrderShipItemTaskCommand createOrderShipItemTaskCommand)
    {
        CreatedOrderShipItemTaskResponse response = await Mediator.Send(createOrderShipItemTaskCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOrderShipItemTaskCommand updateOrderShipItemTaskCommand)
    {
        UpdatedOrderShipItemTaskResponse response = await Mediator.Send(updateOrderShipItemTaskCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteOrderShipItemTaskCommand deleteOrderShipItemTaskCommand)
    {
        DeletedOrderShipItemTaskResponse response = await Mediator.Send(deleteOrderShipItemTaskCommand);
        return Ok(response);
    }
}

