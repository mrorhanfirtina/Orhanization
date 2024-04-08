using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class BuildingController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBuildingCommand createBuildingCommand)
    {
        CreatedBuildingResponse response = await Mediator.Send(createBuildingCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBuildingCommand updateBuildingCommand)
    {
        UpdatedBuildingResponse response = await Mediator.Send(updateBuildingCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteBuildingCommand deleteBuildingCommand)
    {
        DeletedBuildingResponse response = await Mediator.Send(deleteBuildingCommand);
        return Ok(response);
    }
}

