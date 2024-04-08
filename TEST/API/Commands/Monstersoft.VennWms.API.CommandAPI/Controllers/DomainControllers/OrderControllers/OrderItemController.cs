using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.OrderControllers;

public class OrderItemController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateOrderItemCommand createOrderItemCommand)
    {
        CreatedOrderItemResponse response = await Mediator.Send(createOrderItemCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOrderItemCommand updateOrderItemCommand)
    {
        UpdatedOrderItemResponse response = await Mediator.Send(updateOrderItemCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteOrderItemCommand deleteOrderItemCommand)
    {
        DeletedOrderItemResponse response = await Mediator.Send(deleteOrderItemCommand);
        return Ok(response);
    }
}

