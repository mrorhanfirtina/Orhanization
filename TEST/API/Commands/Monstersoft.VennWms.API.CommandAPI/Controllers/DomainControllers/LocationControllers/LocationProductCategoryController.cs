using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class LocationProductCategoryController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLocationProductCategoryCommand createLocationProductCategoryCommand)
    {
        CreatedLocationProductCategoryResponse response = await Mediator.Send(createLocationProductCategoryCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLocationProductCategoryCommand updateLocationProductCategoryCommand)
    {
        UpdatedLocationProductCategoryResponse response = await Mediator.Send(updateLocationProductCategoryCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteLocationProductCategoryCommand deleteLocationProductCategoryCommand)
    {
        DeletedLocationProductCategoryResponse response = await Mediator.Send(deleteLocationProductCategoryCommand);
        return Ok(response);
    }
}


