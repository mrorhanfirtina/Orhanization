using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.CommonControllers;

public class UnsuitReasonController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateUnsuitReasonCommand createUnsuitReasonCommand)
    {
        CreatedUnsuitReasonResponse response = await Mediator.Send(createUnsuitReasonCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateUnsuitReasonCommand updateUnsuitReasonCommand)
    {
        UpdatedUnsuitReasonResponse response = await Mediator.Send(updateUnsuitReasonCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteUnsuitReasonCommand deleteUnsuitReasonCommand)
    {
        DeletedUnsuitReasonResponse response = await Mediator.Send(deleteUnsuitReasonCommand);
        return Ok(response);
    }
}

