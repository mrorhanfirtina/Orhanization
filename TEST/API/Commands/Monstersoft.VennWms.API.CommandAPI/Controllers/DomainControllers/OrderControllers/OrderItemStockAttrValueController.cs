using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.OrderControllers;

public class OrderItemStockAttrValueController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateOrderItemStockAttrValueCommand createOrderItemStockAttrValueCommand)
    {
        CreatedOrderItemStockAttrValueResponse response = await Mediator.Send(createOrderItemStockAttrValueCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOrderItemStockAttrValueCommand updateOrderItemStockAttrValueCommand)
    {
        UpdatedOrderItemStockAttrValueResponse response = await Mediator.Send(updateOrderItemStockAttrValueCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteOrderItemStockAttrValueCommand deleteOrderItemStockAttrValueCommand)
    {
        DeletedOrderItemStockAttrValueResponse response = await Mediator.Send(deleteOrderItemStockAttrValueCommand);
        return Ok(response);
    }
}

