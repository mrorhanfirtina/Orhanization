using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ProductControllers;

public class ItemUnitController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateItemUnitCommand createItemUnitCommand)
    {
        CreatedItemUnitResponse response = await Mediator.Send(createItemUnitCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateItemUnitCommand updateItemUnitCommand)
    {
        UpdatedItemUnitResponse response = await Mediator.Send(updateItemUnitCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteItemUnitCommand deleteItemUnitCommand)
    {
        DeletedItemUnitResponse response = await Mediator.Send(deleteItemUnitCommand);
        return Ok(response);
    }
}

