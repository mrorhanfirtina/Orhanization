using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ProductControllers;

public class ItemUnitConversionController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateItemUnitConversionCommand createItemUnitConversionCommand)
    {
        CreatedItemUnitConversionResponse response = await Mediator.Send(createItemUnitConversionCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateItemUnitConversionCommand updateItemUnitConversionCommand)
    {
        UpdatedItemUnitConversionResponse response = await Mediator.Send(updateItemUnitConversionCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteItemUnitConversionCommand deleteItemUnitConversionCommand)
    {
        DeletedItemUnitConversionResponse response = await Mediator.Send(deleteItemUnitConversionCommand);
        return Ok(response);
    }
}

