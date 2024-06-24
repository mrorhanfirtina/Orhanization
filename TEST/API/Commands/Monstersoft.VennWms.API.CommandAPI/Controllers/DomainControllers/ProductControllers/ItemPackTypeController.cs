using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ProductControllers;

public class ItemPackTypeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateItemPackTypeCommand createItemPackTypeCommand)
    {
        CreatedItemPackTypeResponse response = await Mediator.Send(createItemPackTypeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateItemPackTypeCommand updateItemPackTypeCommand)
    {
        UpdatedItemPackTypeResponse response = await Mediator.Send(updateItemPackTypeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteItemPackTypeCommand deleteItemPackTypeCommand)
    {
        DeletedItemPackTypeResponse response = await Mediator.Send(deleteItemPackTypeCommand);
        return Ok(response);
    }
}

