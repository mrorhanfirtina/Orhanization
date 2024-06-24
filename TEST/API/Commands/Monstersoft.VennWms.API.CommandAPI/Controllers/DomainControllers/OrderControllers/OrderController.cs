using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.OrderControllers;

public class OrderController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateOrderCommand createOrderCommand)
    {
        CreatedOrderResponse response = await Mediator.Send(createOrderCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOrderCommand updateOrderCommand)
    {
        UpdatedOrderResponse response = await Mediator.Send(updateOrderCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteOrderCommand deleteOrderCommand)
    {
        DeletedOrderResponse response = await Mediator.Send(deleteOrderCommand);
        return Ok(response);
    }
}

