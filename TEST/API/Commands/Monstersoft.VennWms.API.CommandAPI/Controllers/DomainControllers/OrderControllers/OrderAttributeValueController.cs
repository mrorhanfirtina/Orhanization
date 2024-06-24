using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.OrderControllers;

public class OrderAttributeValueController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateOrderAttributeValueCommand createOrderAttributeValueCommand)
    {
        CreatedOrderAttributeValueResponse response = await Mediator.Send(createOrderAttributeValueCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOrderAttributeValueCommand updateOrderAttributeValueCommand)
    {
        UpdatedOrderAttributeValueResponse response = await Mediator.Send(updateOrderAttributeValueCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteOrderAttributeValueCommand deleteOrderAttributeValueCommand)
    {
        DeletedOrderAttributeValueResponse response = await Mediator.Send(deleteOrderAttributeValueCommand);
        return Ok(response);
    }
}

