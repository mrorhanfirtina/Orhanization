using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.DepositorControllers;

public class BranchController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBranchCommand createBranchCommand)
    {
        CreatedBranchResponse response = await Mediator.Send(createBranchCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBranchCommand updateBranchCommand)
    {
        UpdatedBranchResponse response = await Mediator.Send(updateBranchCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteBranchCommand deleteBranchCommand)
    {
        DeletedBranchResponse response = await Mediator.Send(deleteBranchCommand);
        return Ok(response);
    }
}

