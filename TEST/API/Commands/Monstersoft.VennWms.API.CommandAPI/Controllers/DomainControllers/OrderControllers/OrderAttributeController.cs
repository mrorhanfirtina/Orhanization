using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.OrderControllers;

public class OrderAttributeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateOrderAttributeCommand createOrderAttributeCommand)
    {
        CreatedOrderAttributeResponse response = await Mediator.Send(createOrderAttributeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOrderAttributeCommand updateOrderAttributeCommand)
    {
        UpdatedOrderAttributeResponse response = await Mediator.Send(updateOrderAttributeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteOrderAttributeCommand deleteOrderAttributeCommand)
    {
        DeletedOrderAttributeResponse response = await Mediator.Send(deleteOrderAttributeCommand);
        return Ok(response);
    }
}

