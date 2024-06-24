using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.DepositorControllers;

public class DistributorController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateDistributorCommand createDisturbitorCommand)
    {
        CreatedDistributorResponse response = await Mediator.Send(createDisturbitorCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateDistributorCommand updateDisturbitorCommand)
    {
        UpdatedDistributorResponse response = await Mediator.Send(updateDisturbitorCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteDistributorCommand deleteDisturbitorCommand)
    {
        DeletedDistributorResponse response = await Mediator.Send(deleteDisturbitorCommand);
        return Ok(response);
    }
}

