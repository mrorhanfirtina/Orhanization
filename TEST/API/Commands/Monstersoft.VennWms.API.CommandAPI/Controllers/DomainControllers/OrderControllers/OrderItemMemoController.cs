using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.OrderControllers;

public class OrderItemMemoController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateOrderItemMemoCommand createOrderItemMemoCommand)
    {
        CreatedOrderItemMemoResponse response = await Mediator.Send(createOrderItemMemoCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOrderItemMemoCommand updateOrderItemMemoCommand)
    {
        UpdatedOrderItemMemoResponse response = await Mediator.Send(updateOrderItemMemoCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteOrderItemMemoCommand deleteOrderItemMemoCommand)
    {
        DeletedOrderItemMemoResponse response = await Mediator.Send(deleteOrderItemMemoCommand);
        return Ok(response);
    }
}

