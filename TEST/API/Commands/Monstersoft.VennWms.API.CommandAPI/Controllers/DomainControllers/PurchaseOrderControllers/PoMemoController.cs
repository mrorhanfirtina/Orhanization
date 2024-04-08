using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.PurchaseOrderControllers;

public class PoMemoController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatePoMemoCommand createPoMemoCommand)
    {
        CreatedPoMemoResponse response = await Mediator.Send(createPoMemoCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdatePoMemoCommand updatePoMemoCommand)
    {
        UpdatedPoMemoResponse response = await Mediator.Send(updatePoMemoCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeletePoMemoCommand deletePoMemoCommand)
    {
        DeletedPoMemoResponse response = await Mediator.Send(deletePoMemoCommand);
        return Ok(response);
    }
}

