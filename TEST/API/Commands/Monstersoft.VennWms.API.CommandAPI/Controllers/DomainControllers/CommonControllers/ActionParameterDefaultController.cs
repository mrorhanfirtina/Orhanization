using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.CommonControllers;

public class ActionParameterDefaultController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateActionParameterDefaultCommand createActionParameterDefaultCommand)
    {
        CreatedActionParameterDefaultResponse response = await Mediator.Send(createActionParameterDefaultCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateActionParameterDefaultCommand updateActionParameterDefaultCommand)
    {
        UpdatedActionParameterDefaultResponse response = await Mediator.Send(updateActionParameterDefaultCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteActionParameterDefaultCommand deleteActionParameterDefaultCommand)
    {
        DeletedActionParameterDefaultResponse response = await Mediator.Send(deleteActionParameterDefaultCommand);
        return Ok(response);
    }
}

