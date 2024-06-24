using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ShipmentControllers;

public class OrderShipItemStockController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateOrderShipItemStockCommand createOrderShipItemStockCommand)
    {
        CreatedOrderShipItemStockResponse response = await Mediator.Send(createOrderShipItemStockCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOrderShipItemStockCommand updateOrderShipItemStockCommand)
    {
        UpdatedOrderShipItemStockResponse response = await Mediator.Send(updateOrderShipItemStockCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteOrderShipItemStockCommand deleteOrderShipItemStockCommand)
    {
        DeletedOrderShipItemStockResponse response = await Mediator.Send(deleteOrderShipItemStockCommand);
        return Ok(response);
    }
}

