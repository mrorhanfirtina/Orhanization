using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.CommonControllers;


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
        return Ok(await Mediator.Send(updateContainerUnitCommand));
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteContainerUnitCommand deleteContainerUnitCommand)
    {
        return Ok(await Mediator.Send(deleteContainerUnitCommand));
    }

}
