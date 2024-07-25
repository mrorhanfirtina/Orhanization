using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.CommonControllers;

public class ActionParameterControllers : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateActionParameterCommand createActionParameterCommand)
    {
        CreatedActionParameterResponse response = await Mediator.Send(createActionParameterCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateActionParameterCommand updateActionParameterCommand)
    {
        UpdatedActionParameterResponse response = await Mediator.Send(updateActionParameterCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteActionParameterCommand deleteActionParameterCommand)
    {
        DeletedActionParameterResponse response = await Mediator.Send(deleteActionParameterCommand);
        return Ok(response);
    }
}
