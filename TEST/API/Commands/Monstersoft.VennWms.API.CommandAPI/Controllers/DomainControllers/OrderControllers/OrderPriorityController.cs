using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.OrderControllers;

public class OrderPriorityController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateOrderPriorityCommand createOrderPriorityCommand)
    {
        CreatedOrderPriorityResponse response = await Mediator.Send(createOrderPriorityCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOrderPriorityCommand updateOrderPriorityCommand)
    {
        UpdatedOrderPriorityResponse response = await Mediator.Send(updateOrderPriorityCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteOrderPriorityCommand deleteOrderPriorityCommand)
    {
        DeletedOrderPriorityResponse response = await Mediator.Send(deleteOrderPriorityCommand);
        return Ok(response);
    }
}


