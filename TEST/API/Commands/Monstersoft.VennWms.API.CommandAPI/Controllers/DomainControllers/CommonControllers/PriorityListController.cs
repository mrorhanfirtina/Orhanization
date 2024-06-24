using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.CommonControllers;

public class PriorityListController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatePriorityListCommand createPriorityListCommand)
    {
        CreatedPriorityListResponse response = await Mediator.Send(createPriorityListCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdatePriorityListCommand updatePriorityListCommand)
    {
        UpdatedPriorityListResponse response = await Mediator.Send(updatePriorityListCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeletePriorityListCommand deletePriorityListCommand)
    {
        DeletedPriorityListResponse response = await Mediator.Send(deletePriorityListCommand);
        return Ok(response);
    }
}


