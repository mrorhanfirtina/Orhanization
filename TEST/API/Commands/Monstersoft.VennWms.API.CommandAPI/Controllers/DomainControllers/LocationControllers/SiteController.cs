using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class SiteController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateSiteCommand createSiteCommand)
    {
        CreatedSiteResponse response = await Mediator.Send(createSiteCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateSiteCommand updateSiteCommand)
    {
        UpdatedSiteResponse response = await Mediator.Send(updateSiteCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteSiteCommand deleteSiteCommand)
    {
        DeletedSiteResponse response = await Mediator.Send(deleteSiteCommand);
        return Ok(response);
    }
}

