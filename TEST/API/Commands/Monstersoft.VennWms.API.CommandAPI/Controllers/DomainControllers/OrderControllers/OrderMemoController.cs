using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.OrderControllers;

public class OrderMemoController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateOrderMemoCommand createOrderMemoCommand)
    {
        CreatedOrderMemoResponse response = await Mediator.Send(createOrderMemoCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOrderMemoCommand updateOrderMemoCommand)
    {
        UpdatedOrderMemoResponse response = await Mediator.Send(updateOrderMemoCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteOrderMemoCommand deleteOrderMemoCommand)
    {
        DeletedOrderMemoResponse response = await Mediator.Send(deleteOrderMemoCommand);
        return Ok(response);
    }
}

