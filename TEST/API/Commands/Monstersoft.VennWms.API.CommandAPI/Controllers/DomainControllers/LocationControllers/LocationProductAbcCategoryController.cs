using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class LocationProductAbcCategoryController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLocationProductAbcCategoryCommand createLocationProductAbcCategoryCommand)
    {
        CreatedLocationProductAbcCategoryResponse response = await Mediator.Send(createLocationProductAbcCategoryCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLocationProductAbcCategoryCommand updateLocationProductAbcCategoryCommand)
    {
        UpdatedLocationProductAbcCategoryResponse response = await Mediator.Send(updateLocationProductAbcCategoryCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteLocationProductAbcCategoryCommand deleteLocationProductAbcCategoryCommand)
    {
        DeletedLocationProductAbcCategoryResponse response = await Mediator.Send(deleteLocationProductAbcCategoryCommand);
        return Ok(response);
    }
}


