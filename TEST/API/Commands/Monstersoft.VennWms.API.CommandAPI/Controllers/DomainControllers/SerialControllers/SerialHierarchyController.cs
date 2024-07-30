using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.SerialControllers;

public class SerialHierarchyController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateSerialHierarchyCommand createSerialHierarchyCommand)
    {
        CreatedSerialHierarchyResponse response = await Mediator.Send(createSerialHierarchyCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateSerialHierarchyCommand updateSerialHierarchyCommand)
    {
        UpdatedSerialHierarchyResponse response = await Mediator.Send(updateSerialHierarchyCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteSerialHierarchyCommand deleteSerialHierarchyCommand)
    {
        DeletedSerialHierarchyResponse response = await Mediator.Send(deleteSerialHierarchyCommand);
        return Ok(response);
    }
}

