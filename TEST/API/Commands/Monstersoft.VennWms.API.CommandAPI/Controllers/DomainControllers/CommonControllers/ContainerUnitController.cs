using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.CommonControllers;

public class ContainerUnitController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateContainerUnitCommand createContainerUnitCommand)
    {
        CreatedContainerUnitResponse response = await Mediator.Send(createContainerUnitCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateContainerUnitCommand updateContainerUnitCommand)
    {
        UpdatedContainerUnitResponse response = await Mediator.Send(updateContainerUnitCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteContainerUnitCommand deleteContainerUnitCommand)
    {
        DeletedContainerUnitResponse response = await Mediator.Send(deleteContainerUnitCommand);
        return Ok(response);
    }
}

