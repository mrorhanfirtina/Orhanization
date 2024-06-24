using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.CommonControllers;

public class UnitController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateUnitCommand createUnitCommand)
    {
        CreatedUnitResponse response = await Mediator.Send(createUnitCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateUnitCommand updateUnitCommand)
    {
        UpdatedUnitResponse response = await Mediator.Send(updateUnitCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteUnitCommand deleteUnitCommand)
    {
        DeletedUnitResponse response = await Mediator.Send(deleteUnitCommand);
        return Ok(response);
    }
}

