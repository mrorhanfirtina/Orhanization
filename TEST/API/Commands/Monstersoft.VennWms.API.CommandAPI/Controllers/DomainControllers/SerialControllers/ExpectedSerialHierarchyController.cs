using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.SerialControllers;

public class ExpectedSerialHierarchyController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateExpectedSerialHierarchyCommand createExpectedSerialHierarchyCommand)
    {
        CreatedExpectedSerialHierarchyResponse response = await Mediator.Send(createExpectedSerialHierarchyCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateExpectedSerialHierarchyCommand updateExpectedSerialHierarchyCommand)
    {
        UpdatedExpectedSerialHierarchyResponse response = await Mediator.Send(updateExpectedSerialHierarchyCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteExpectedSerialHierarchyCommand deleteExpectedSerialHierarchyCommand)
    {
        DeletedExpectedSerialHierarchyResponse response = await Mediator.Send(deleteExpectedSerialHierarchyCommand);
        return Ok(response);
    }
}

