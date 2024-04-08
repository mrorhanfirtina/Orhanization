using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class SiteDepositorController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateSiteDepositorCommand createSiteDepositorCommand)
    {
        CreatedSiteDepositorResponse response = await Mediator.Send(createSiteDepositorCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateSiteDepositorCommand updateSiteDepositorCommand)
    {
        UpdatedSiteDepositorResponse response = await Mediator.Send(updateSiteDepositorCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteSiteDepositorCommand deleteSiteDepositorCommand)
    {
        DeletedSiteDepositorResponse response = await Mediator.Send(deleteSiteDepositorCommand);
        return Ok(response);
    }
}

