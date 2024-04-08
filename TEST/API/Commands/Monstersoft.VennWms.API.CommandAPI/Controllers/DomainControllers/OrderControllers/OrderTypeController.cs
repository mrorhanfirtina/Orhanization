using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.OrderControllers;

public class OrderTypeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateOrderTypeCommand createOrderTypeCommand)
    {
        CreatedOrderTypeResponse response = await Mediator.Send(createOrderTypeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOrderTypeCommand updateOrderTypeCommand)
    {
        UpdatedOrderTypeResponse response = await Mediator.Send(updateOrderTypeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteOrderTypeCommand deleteOrderTypeCommand)
    {
        DeletedOrderTypeResponse response = await Mediator.Send(deleteOrderTypeCommand);
        return Ok(response);
    }
}

