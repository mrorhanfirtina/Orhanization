using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.PurchaseOrderControllers;

public class PurchaseOrderController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatePurchaseOrderCommand createPurchaseOrderCommand)
    {
        CreatedPurchaseOrderResponse response = await Mediator.Send(createPurchaseOrderCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdatePurchaseOrderCommand updatePurchaseOrderCommand)
    {
        UpdatedPurchaseOrderResponse response = await Mediator.Send(updatePurchaseOrderCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeletePurchaseOrderCommand deletePurchaseOrderCommand)
    {
        DeletedPurchaseOrderResponse response = await Mediator.Send(deletePurchaseOrderCommand);
        return Ok(response);
    }
}

