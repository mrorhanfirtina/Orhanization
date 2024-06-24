using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.CommonControllers;

public class ReserveReasonController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateReserveReasonCommand createReserveReasonCommand)
    {
        CreatedReserveReasonResponse response = await Mediator.Send(createReserveReasonCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReserveReasonCommand updateReserveReasonCommand)
    {
        UpdatedReserveReasonResponse response = await Mediator.Send(updateReserveReasonCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteReserveReasonCommand deleteReserveReasonCommand)
    {
        DeletedReserveReasonResponse response = await Mediator.Send(deleteReserveReasonCommand);
        return Ok(response);
    }
}

